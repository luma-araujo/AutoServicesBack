using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {

        //Lista de veículos, enquanto não há conexão com o banco de dados
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


        //Retorna veículos da lista
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Veiculos); 
        }

        //Adiciona veículo
        [HttpPost]
        public IActionResult Post([FromBody] Veiculo novoVeiculo) { //Recebe o veículo novo que vem do corpo da requisição no React

            //Verificar se o veículo já existe

            //Verficar Id do veiculo
            if (Veiculos.Any())  //verifica se a lista não está vazia
            {
                novoVeiculo.Id = Veiculos.Max(v => v.Id) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novoVeiculo.Id = 1;
            }
            
            //Verificar se o cliente existe

            //Adicionar o novo veículo na lista

            Veiculos.Add(novoVeiculo);
            return Ok(Veiculos);  

        }

        [HttpPut]

        [HttpDelete]

        private readonly ILogger<VeiculoController> _logger;

        public VeiculoController(ILogger<VeiculoController> logger)
        {
            _logger = logger;
        }

    }
}
