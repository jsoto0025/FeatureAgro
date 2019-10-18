<!--B-BotonesRedesSociales-->

Account/Login.cshtml

                    @{
                        if ((Model.ExternalLogins?.Count ?? 0) > 0)
                        {
                            <form id="external-account" action="BeginExternalLogin?returnUrl=@Model.ReturnUrl" method="post" class="form-horizontal">
                                <div>
                                    <p>
                                        @foreach (var provider in Model.ExternalLogins)
                                        {
                                            <button type="submit" class="btn btn-primary" name="provider" value="@provider.Name" title="Log in using your @provider.DisplayName account">@provider.DisplayName</button>
                                        }
                                    </p>
                                </div>
                            </form>
                        }
                    }