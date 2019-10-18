Startup.cs
/*B-AddsAutenticar*/


.AddGoogle(options =>
{
    // Provide the Google Client ID
    options.ClientId = "84213285064-3bu6c7f6iuov5e2nj71j8kp09ldsgg8p.apps.googleusercontent.com";
    // Register with User Secrets using:
    // dotnet user-secrets set "Authentication:Google:ClientId" "{Client ID}"

    // Provide the Google Client Secret
    options.ClientSecret = "USukES39oKelSIhWjI5Nj2W6";
    // Register with User Secrets using:
    // dotnet user-secrets set "Authentication:Google:ClientSecret" "{Client Secret}"

    options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
    options.ClaimActions.MapJsonKey("urn:google:locale", "locale", "string");
    options.SaveTokens = true;

    options.Events.OnCreatingTicket = ctx =>
    {
        List<AuthenticationToken> tokens = ctx.Properties.GetTokens().ToList();

        tokens.Add(new AuthenticationToken()
        {
            Name = "TicketCreated",
            Value = DateTime.UtcNow.ToString()
        });

        ctx.Properties.StoreTokens(tokens);

        return Task.CompletedTask;
    };
})