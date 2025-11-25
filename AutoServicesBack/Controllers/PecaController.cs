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
                IdPeca = 1,
                Nome = "Bateria",
                PrecoUnitario = 100,
                QuantidadeEstoque = 4
            },
            new Peca
            {
                IdPeca = 2,
                Nome = "Radiador",
                PrecoUnitario = 40,
                QuantidadeEstoque = 5
            },
        };


        //Retorna peças da lista
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(Pecas); 
        }

        //Adiciona peça
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Peca novaPeca) { //Recebe a peça nova que vem do corpo da requisição no React

            //Verificar se a peça já existe


            //Verficar id da peça
            if (Pecas.Any())  //verifica se a lista não está vazia
            {
                novaPeca.IdPeca = Pecas.Max(v => v.IdPeca) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novaPeca.IdPeca = 1;
            }

            //Adicionar a nova peça na lista

            Pecas.Add(novaPeca);

            return CreatedAtAction(nameof(Get), new Peca { IdPeca = novaPeca.IdPeca }, novaPeca); //Retorna a peça criada

        }



        private readonly ILogger<PecaController> _logger;

        public PecaController(ILogger<PecaController> logger)
        {
            _logger = logger;
        }

    }
}
