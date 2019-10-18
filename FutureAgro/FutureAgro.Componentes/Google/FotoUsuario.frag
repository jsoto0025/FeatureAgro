<!--B-FotoUsuario-->
<i class="fas fa-user mr-3"></i>
<!--E-FotoUsuario-->

Views/Shared/_Layout.cshtml

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