using ContractosCommon.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Alquileres.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivosWipsController : ControllerBase
    {
		
		private readonly ILogger<ActivosWipsController> _logger;

        public ActivosWipsController(ILogger<ActivosWipsController> logger)
        {
            _logger = logger;
        }

		[HttpGet]
		public IActionResult Get()
		{
			 var activos = new List<Activo> {
				new Activo { Id = 1, Nombre = "Activo 1" },
				new Activo { Id = 2, Nombre = "Activo 2" },
				new Activo { Id = 3, Nombre = "Activo 3" }
        	};

			// Retornamos solo los nombres
			return Ok(activos);
		}
	}
}
