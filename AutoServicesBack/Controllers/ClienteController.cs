using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        //Lista de clientes, enquanto não há conexão com o banco de dados
        static List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente
            {
                Id = 1,
                Nome = "Carlos",
                Telefone = "34900000000",
                Email = "carlos@gmail.com"
            },
            new Cliente
            {
                Id = 1,
                Nome = "Maria",
                Telefone = "34900000001",
                Email = "maria@gmail.com"
            },
          
        };


        //Retorna clientes da lista
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes); 
        }

        //Adiciona cliente
        [HttpPost]
        public IActionResult Post([FromBody] Cliente novoCliente) { //Recebe o cliente novo que vem do corpo da requisição no React

            //Verificar se o cliente já existe



            //Verficar Id do cliente
            if (Clientes.Any())  //verifica se a lista não está vazia
            {
                novoCliente.Id = Clientes.Max(v => v.Id) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novoCliente.Id = 1;
            }

            //Adicionar o novo cliente na lista

            Clientes.Add(novoCliente);

            return CreatedAtAction(nameof(Get), new Cliente { IdCliente = novoCliente.Id }, novoCliente); //Retorna o cliente criado

            return Ok(Clientes);  

        }



        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

    }
}
