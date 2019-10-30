Fragment ControlAmbienteBase_MetodosModulosController {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: MetodosModulosController
	Destinations: ArchivosBasicos_ModulosController
	SourceCode: [ALTERCODE-FRAG]		
		// GET: Modulos/Ambiente/5
		public async Task<IActionResult> Ambiente(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var modulo = await _context.Modulos
				.FirstOrDefaultAsync(m => m.IdModulo == id);

			var medidasModulo = _context.Medidas
							.Where(r => r.IdModulo == id);

			/*B-ChartsControllerDetalle*/

			if (modulo == null)
			{
				return NotFound();
			}

			return View(modulo);
		}

		private static ChartData ObtenerDatosMedida(IQueryable<Medida> medidasModulo, TipoMedida tipoMedida, string color, string backgroundColor)
		{
			var medidas = medidasModulo
											.Where(r => r.TipoMedida == tipoMedida)
											.OrderByDescending(r => r.Fecha)
											.Take(10);

			var datosmedida = new ChartData()
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
			return datosmedida;
		}

		private void CargarLimites()
		{
			/*BCP-CustomizationPoint */

			ViewData["TemperaturaLimiteSuperior"] = (double)22;
			ViewData["TemperaturaLimiteInferior"] = (double)18;
			ViewData["HumedadLimiteSuperior"] = 75;
			ViewData["HumedadLimiteInferior"] = 50;
			ViewData["LuminosidadLimiteSuperior"] = 700;
			ViewData["LuminosidadLimiteInferior"] = 450;

			/*ECP-CustomizationPoint */
		}

	[/ALTERCODE-FRAG]
}