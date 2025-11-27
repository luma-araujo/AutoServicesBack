using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdemServicoController : ControllerBase
    {

        //Lista de ordens, enquanto não há conexão com o banco de dados
        static List<OrdemServico> OrdensDeServico = new List<OrdemServico>
        {
            new OrdemServico  //objeto que armazena os dados da ordem de serviço
            {
                IdOS = 1,
                IdCliente = 1,
                IdVeiculo = 1,
                DescricaoProblema = "Não liga",
                DataAbertura = DateTime.Today,
                StatusServico = "Concluida",
                ProcedimentoRealizado = "Troca de bateria",
            },
            new OrdemServico
            {
                IdOS = 2,
                IdCliente = 2,
                IdVeiculo = 2,
                DescricaoProblema = "Não freia",
                DataAbertura = DateTime.Today,
                StatusServico = "Aberta",
                ProcedimentoRealizado = "Troca de freio",
            },

        };


        //Retorna ordens da lista
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(OrdensDeServico); 
        }
        //Retorna ordem por Id

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        { 
            var ordemServico = OrdensDeServico.FirstOrDefault(ordemServico => ordemServico.IdOS == id);
            if (ordemServico == null) 
            {
                return NotFound();
            } else 
            { 
                return Ok(ordemServico);
            }
        }

        //Cria ordem
        [HttpPost]
        public IActionResult Cadastrar([FromBody] OrdemServico novaOrdem)
        { //Recebe a ordem nova que vem do corpo da requisição no React

            //Verificar se a ordem já existe



            //Verficar Id da ordem
            if (OrdensDeServico.Any())  //verifica se a lista não está vazia
            {
                novaOrdem.IdOS = OrdensDeServico.Max(novaOrdem => novaOrdem.IdOS) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
            }
            else
            {
                novaOrdem.IdOS = 1;
            }

            //Adicionar a nova ordem na lista

            OrdensDeServico.Add(novaOrdem);

            return CreatedAtAction(nameof(Listar), new OrdemServico { IdOS = novaOrdem.IdOS }, novaOrdem); //Retorna a ordem criada
        }



        //private readonly ILogger<OrdemServicoController> _logger;

        //public OrdemServicoController(ILogger<OrdemServicoController> logger)
        //{
        //    _logger = logger;
        //}

    }
}
