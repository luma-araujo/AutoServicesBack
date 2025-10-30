using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {

        //Lista de ve�culos, enquanto n�o h� conex�o com o banco de dados
        static List<Veiculo> Veiculos = new List<Veiculo>
        {
            new Veiculo
            {
                Id = 1,
                Marca = "Ford",
                Modelo = "Fiesta",
                Ano = 2015,
                Placa = "ABC-1234",
                IdCliente= 1
            },
            new Veiculo
            {
                Id = 2,
                Marca = "Chevrolet",
                Modelo = "Onix",
                Ano = 2018,
                Placa = "DEF-5678",
                IdCliente= 2
            },
          
        };


        //Retorna ve�culos da lista
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Veiculos); 
        }

        //Adiciona ve�culo
        [HttpPost]
        public IActionResult Post([FromBody] Veiculo novoVeiculo) { //Recebe o ve�culo novo que vem do corpo da requisi��o no React

            //Verificar se o ve�culo j� existe

            //Verficar Id do veiculo
            if (Veiculos.Any())  //verifica se a lista n�o est� vazia
            {
                novoVeiculo.Id = Veiculos.Max(v => v.Id) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novoVeiculo.Id = 1;
            }
            
            //Verificar se o cliente existe

            //Adicionar o novo ve�culo na lista

            Veiculos.Add(novoVeiculo);
            return Ok(Veiculos);  

        }

        private readonly ILogger<VeiculoController> _logger;

        public VeiculoController(ILogger<VeiculoController> logger)
        {
            _logger = logger;
        }

    }
}
