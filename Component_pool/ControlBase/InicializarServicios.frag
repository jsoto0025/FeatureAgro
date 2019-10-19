Fragment ControlBase_InicializarServicios {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		app.UseSignalR(config =>
		{
			config.MapHub<FutureAgroHub>("/futureagrohub");
		});
		FutureAgroHub = app.ApplicationServices.GetService<IHubContext<FutureAgroHub>>();
	[/ALTERCODE-FRAG]
}
