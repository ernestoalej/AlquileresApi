using Microsoft.AspNetCore.Mvc;

namespace Alquileres.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivosWipsController : ControllerBase
    {
		private static readonly string[] Activos = new[] {
			"Local Comercial - Av. Bol�var 102",
			"Galp�n Industrial - Zona Sur",
			"Apartamento Amoblado - Torre Altamira",
			"Oficina Corporativa - Centro Empresarial Miranda",
			"Dep�sito Log�stico - Parque Industrial La Yaguara",
			"Casa Quinta - Urb. El Para�so",
			"Terreno Bald�o - Sector La Encrucijada",
			"Estacionamiento Techado - Plaza Central",
			"Kiosco de Comida - Boulevard Sucre",
			"Consultorio M�dico - Cl�nica San Rafael"
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
