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
                IdCliente = 1,
                Nome = "Carlos",
                Telefone = "34900000000",
                Email = "carlos@gmail.com"
            },
            new Cliente
            {
                IdCliente = 2,
                Nome = "Maria",
                Telefone = "34900000001",
                Email = "maria@gmail.com"
            },
          
        };


        //Retorna clientes da lista
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(Clientes); 
        }
        
        //Retorna cliente por Id

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        { 
            var cliente = Clientes.FirstOrDefault(cliente => cliente.IdCliente == id);
            if (cliente == null) 
            {
                return NotFound();
            } else 
            { 
                return Ok(cliente);
            }
        }

        //Adiciona cliente
        [HttpPost("id")]
        public IActionResult Cadastrar(int id, [FromBody] Cliente novoCliente)
        { //Recebe o cliente novo que vem do corpo da requisição no React

            //Verificar se o cliente já existe

            if (novoCliente == null)
            {
                return BadRequest("O corpo da requisição não pode ser vazio.");
            }

            //Verficar Id do cliente
            if (Clientes.Any())  //verifica se a lista não está vazia
            {
                novoCliente.IdCliente = Clientes.Max(cliente => cliente.IdCliente) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novoCliente.IdCliente = 1;
            }

            //Adicionar o novo cliente na lista

            Clientes.Add(novoCliente);

            return CreatedAtAction(nameof(Listar), new Cliente { IdCliente = novoCliente.IdCliente }, novoCliente); //Retorna o cliente criado

            //return Ok(Clientes);  

        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Cliente clienteAtualizado)
            {

            if (clienteAtualizado == null)
            {
                return BadRequest("O corpo da requisição não pode ser vazio.");
            }

            var clienteExistente = Clientes.FirstOrDefault(cliente => cliente.IdCliente == clienteAtualizado.IdCliente);

            if (clienteExistente == null)
            {
                return NotFound("Cliente não encontrado.");
            }


            //Atualiza os dados do cliente existente
            clienteExistente.Nome = clienteAtualizado.Nome;
            clienteExistente.Telefone = clienteAtualizado.Telefone;
            clienteExistente.Email = clienteAtualizado.Email;
            return Ok(clienteExistente); //Retorna o cliente atualizado

            }

        [HttpDelete("{id}")]

        public IActionResult Excluir(int id)
        {
            var cliente = Clientes.FirstOrDefault(cliente => cliente.IdCliente == id);

            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            Clientes.Remove(cliente);
            return NoContent(); //Retorna 204 No Content
        }


        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

    }
}
