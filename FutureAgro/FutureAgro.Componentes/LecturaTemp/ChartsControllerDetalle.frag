/*B-ChartsControllerDetalle*/
Controllers/ModulosController.cs

            ChartData datosTemperatura = ObtenerDatosMedida(medidasModulo, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
            ViewData["DatosTemperatura"] = datosTemperatura;
