Fragment Google_FotoUsuario {
  Action: replace
  Priority: low
  PointBracketsLan: html
  FragmentationPoints: FotoUsuario
  Destinations: ArchivosBasicos__Layout
  SourceCode: [ALTERCODE-FRAG]
    @{
		var picture = Context.User.Claims.FirstOrDefault(r => r.Type == "urn:google:picture")?.Value;
    }
    @if (!string.IsNullOrWhiteSpace(picture))
    {
		<img class="mr-2 rounded-circle" src="@picture" width="60" height="60" />
    }
    else
    {
		<i class="fas fa-user mr-3"></i>
    }
  [/ALTERCODE-FRAG]
}