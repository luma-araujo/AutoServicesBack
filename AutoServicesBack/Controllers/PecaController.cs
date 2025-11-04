using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PecaController : ControllerBase
    {

        //Lista de peças, enquanto não há conexão com o banco de dados
        static List<Peca> Pecas = new List<Peca>
        {
            new Peca
            {
                Id = 1,
                Nome = "Bateria",
                PrecoUnitario = 100,
                QuantidadeEstoque = 4
            },
            new Peca
            {
                Id = 1,
                Nome = "Radiador",
                PrecoUnitario = 40,
                QuantidadeEstoque = 5
            },
        };


        //Retorna peças da lista
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Pecas); 
        }

        //Adiciona peça
        [HttpPost]
        public IActionResult Post([FromBody] Peca novaPeca) { //Recebe a peça nova que vem do corpo da requisição no React

            //Verificar se o cliente já existe



            //Verficar id da peça
            if (Pecas.Any())  //verifica se a lista não está vazia
            {
                novaPeca.Id = Pecas.Max(v => v.Id) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novaPeca.Id = 1;
            }

            //Adicionar a nova peça na lista

            Pecas.Add(novaPeca);

            return CreatedAtAction(nameof(Get), new Peca { IdPeca = novaPeca.Id }, novaPeca); //Retorna a peça criada

            return Ok(Pecas);  

        }



        private readonly ILogger<PecaController> _logger;

        public PecaController(ILogger<PecaController> logger)
        {
            _logger = logger;
        }

    }
}
