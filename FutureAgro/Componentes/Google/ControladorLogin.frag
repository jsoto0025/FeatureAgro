Fragment Google_ControladorLogin {
	Action: add
	Priority: low
	PointBracketsLan: java
	FragmentationPoints: ControladorLogin
	Destinations: ArchivosBasicos_AccountController
	SourceCode: [ALTERCODE-FRAG]				
		public IActionResult BeginExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action("ExternalLogin", "Account", new { returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }
        
        #region snippet_OnGetCallbackAsync
        public async Task<IActionResult> ExternalLogin(string returnUrl = null, string remoteError = null)
        {
            var model = new ExternalLoginModel
            {
                ReturnUrl = returnUrl ?? Url.Content("~/")
            };

            if (remoteError != null)
            {
                model.ErrorMessage = $"Error from external provider: {remoteError}";
                return RedirectToPage("/Account/Login", new { ReturnUrl = model.ReturnUrl });
            }

            var info = await signInManager.GetExternalLoginInfoAsync();

            if (info == null)
            {
                model.ErrorMessage = "Error loading external login information.";
                return RedirectToPage("/Account/Login", new { ReturnUrl = model.ReturnUrl });
            }

            // Sign in the user with this external login provider if the user already 
            // has a login.
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (result.Succeeded)
            {
                // Store the access token and resign in so the token is included in
                // in the cookie
                var user = await userManager.FindByLoginAsync(info.LoginProvider,
                    info.ProviderKey);

                var props = new AuthenticationProperties();
                props.StoreTokens(info.AuthenticationTokens);

                await signInManager.SignInAsync(user, props, info.LoginProvider);

                //_logger.LogInformation("{Name} logged in with {LoginProvider} provider.",
                //    info.Principal.Identity.Name, info.LoginProvider);

                return LocalRedirect(model.ReturnUrl);
            }

            if (result.IsLockedOut)
            {
                return RedirectToPage("./Lockout");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an 
                // account.
                model.LoginProvider = info.LoginProvider;

                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    model.Email = info.Principal.FindFirstValue(ClaimTypes.Email);
                }

                return View(model);
            }
        }
        #endregion
        
        public async Task<IActionResult> Confirmation(ExternalLoginModel model, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // Get the information about the user from the external login provider
            var info = await signInManager.GetExternalLoginInfoAsync();

            if (info == null)
            {
                model.ErrorMessage =
                    "Error loading external login information during confirmation.";

                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    result = await userManager.AddLoginAsync(user, info);

                    if (result.Succeeded)
                    {
                        // If they exist, add claims to the user for:
                        //    Given (first) name
                        //    Locale
                        //    Picture
                        if (info.Principal.HasClaim(c => c.Type == ClaimTypes.GivenName))
                        {
                            await userManager.AddClaimAsync(user,
                                info.Principal.FindFirst(ClaimTypes.GivenName));
                        }

                        if (info.Principal.HasClaim(c => c.Type == "urn:google:locale"))
                        {
                            await userManager.AddClaimAsync(user,
                                info.Principal.FindFirst("urn:google:locale"));
                        }

                        if (info.Principal.HasClaim(c => c.Type == "urn:google:picture"))
                        {
                            await userManager.AddClaimAsync(user,
                                info.Principal.FindFirst("urn:google:picture"));
                        }

                        // Include the access token in the properties
                        var props = new AuthenticationProperties();
                        props.StoreTokens(info.AuthenticationTokens);
                        props.IsPersistent = true;

                        await signInManager.SignInAsync(user, props);

                        //_logger.LogInformation(
                        //    "User created an account using {Name} provider.",
                        //    info.LoginProvider);

                        return LocalRedirect(returnUrl);
                    }
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            model.LoginProvider = info.LoginProvider;
            model.ReturnUrl = returnUrl;
            return View(model);
        }
	[/ALTERCODE-FRAG]
}