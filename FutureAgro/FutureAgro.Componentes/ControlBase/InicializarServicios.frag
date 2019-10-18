/*B-InicializarServicios*/
Startup.cs

app.UseSignalR(config =>
{
    config.MapHub<FutureAgroHub>("/futureagrohub");
});
FutureAgroHub = app.ApplicationServices.GetService<IHubContext<FutureAgroHub>>();