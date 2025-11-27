using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdemServicoPecaController : ControllerBase
    {

        //Lista de peças utilizadas em OS, enquanto não há conexão com o banco de dados
        static List<OrdemServicoPeca> OrdemServicoPecas = new List<OrdemServicoPeca>
        {
            new OrdemServicoPeca
            {
                IdOS = 1,
                IdPeca = 1,
                QuantidadeUtilizada = 2,
            },
            new OrdemServicoPeca
            {
                IdOS = 2,
                IdPeca = 2,
                QuantidadeUtilizada = 1,
            },
          
        };


        //Retorna as peças usadas da lista
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(OrdemServicoPecas); 
        }
        //Retorna cliente por Id

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        { 
            var oSPeca = OrdemServicoPecas.FirstOrDefault(oSPeca => oSPeca.IdOS == id);
            if (oSPeca == null) 
            {
                return NotFound();
            } else 
            { 
                return Ok(oSPeca);
            }
        }

        //Registra peça usada em OS
        //[HttpPost]
        //public IActionResult Cadastrar([FromBody] Cliente novoCliente) { //Recebe o cliente novo que vem do corpo da requisição no React

        //    //Verificar se o cliente já existe



        //    //Verficar Id do cliente
        //    if (Clientes.Any())  //verifica se a lista não está vazia
        //    {
        //        novoCliente.IdCliente = Clientes.Max(v => v.IdCliente) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
        //    }
        //    else
        //    {
        //        novoCliente.IdCliente = 1;
        //    }

        //    //Adicionar o novo cliente na lista

        //    Clientes.Add(novoCliente);

        //    return CreatedAtAction(nameof(Listar), new Cliente { IdCliente = novoCliente.IdCliente }, novoCliente); //Retorna o cliente criado

        //    //return Ok(Clientes);  

        //}



        private readonly ILogger<OrdemServicoPecaController> _logger;

        public OrdemServicoPecaController(ILogger<OrdemServicoPecaController> logger)
        {
            _logger = logger;
        }

    }
}
