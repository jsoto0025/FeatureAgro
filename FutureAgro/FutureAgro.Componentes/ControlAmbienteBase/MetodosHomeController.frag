/*B-MetodosHomeController*/
FutureAgro/Controllers/HomeController

private static ChartData ObtenerDatosMedida(IQueryable<Medida> medidasModulo, TipoMedida tipoMedida, string color, string backgroundColor)
{
    var medidas = medidasModulo
                                    .Where(r => r.TipoMedida == tipoMedida)
                                    .OrderByDescending(r => r.Fecha)
                                    .Take(10);

    var datosMedida = new ChartData()
    {
        Labels = medidas.Select(r => r.Fecha.ToLongTimeString()).ToArray(),
        Datasets = new ChartDataSet[] {
            new ChartDataSet()
            {
                Label = tipoMedida.ToString(),
                BackgroundColor = backgroundColor,
                BorderColor = color,
                BorderWidth = 1,
                PointBackgroundColor = color,
                Data = medidas.Select(r => r.Valor).ToArray()
            }
        }
    };
    return datosMedida;
}