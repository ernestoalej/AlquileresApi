using Microsoft.AspNetCore.Mvc;

namespace Alquileres.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivosWipsController : ControllerBase
    {
		private static readonly string[] Activos = new[] {
			"Local Comercial - Av. Bolívar 102",
			"Galpón Industrial - Zona Sur",
			"Apartamento Amoblado - Torre Altamira",
			"Oficina Corporativa - Centro Empresarial Miranda",
			"Depósito Logístico - Parque Industrial La Yaguara",
			"Casa Quinta - Urb. El Paraíso",
			"Terreno Baldío - Sector La Encrucijada",
			"Estacionamiento Techado - Plaza Central",
			"Kiosco de Comida - Boulevard Sucre",
			"Consultorio Médico - Clínica San Rafael"
		};

		private readonly ILogger<ActivosWipsController> _logger;

        public ActivosWipsController(ILogger<ActivosWipsController> logger)
        {
            _logger = logger;
        }

		[HttpGet]
		public IEnumerable<String> Get()
		{
			return Activos.ToList();
		}
	}
}
