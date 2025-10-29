using Microsoft.AspNetCore.Mvc;


namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {

        List<string> Veiculo = new List<string>
        {
            "Carro",
            "Moto",
            "Caminhão",
            "Ônibus"
        };

        public IActionResult Get()
        {
            {
                return Ok(Veiculo);
            }
        }

        private readonly ILogger<VeiculoController> _logger;

        public VeiculoController(ILogger<VeiculoController> logger)
        {
            _logger = logger;
        }

    


    }
}
