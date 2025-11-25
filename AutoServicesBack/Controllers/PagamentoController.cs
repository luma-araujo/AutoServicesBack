using Microsoft.AspNetCore.Mvc;
using AutoServicesBack.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoServicesBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagamentoController : ControllerBase
    {

        //Lista de veículos, enquanto não há conexão com o banco de dados
        static List<Pagamento> Pagamentos = new List<Pagamento>
        {
            new Pagamento
            {
                IdPagamento = 1,
                IdOrdemServico = 1,
                ValorTotal = 250.0,
                DataPagamento = DateTime.Today,
                FormaPagamento = "Cartão de crédito",
                StatusPagamento = "Pago"
            },
            new Pagamento
            {
                IdPagamento = 2,
                IdOrdemServico = 2,
                ValorTotal = 300.0,
                DataPagamento = DateTime.Today,
                FormaPagamento = "Cartão de crédito",
                StatusPagamento = "Pendente"
            },

        };


        //Retorna pagamentos da lista
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(Pagamentos);
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            var pagamento = Pagamentos.FirstOrDefault(pagamento => pagamento.IdPagamento == id);
            if (pagamento == null)
            {
                return NotFound();
            } else
            {
                return Ok(pagamento);
            }
        }


        //Cria novo pagamento
        //[HttpPost]
        //public IActionResult Criar([FromBody] Pagamento novoPagamento) { //Recebe o pagamento novo que vem do corpo da requisição no React

        //    //Verificar se o pagamento já existe

        //    //Verficar Id do Pagamento
        //    if (Pagamentos.Any())  //verifica se a lista não está vazia
        //    {
        //        novoPagamento.IdPagamento = Pagamentos.Max(v => v.IdPagamento) + 1; //checa o maior Id da lista e adiciona 1 para incrementar
        //    }
        //    else
        //    {
        //        novoPagamento.IdPagamento = 1;
        //    }

        //    //Verificar se a OS existe

        //    //Adicionar o novo pagamento na lista

        //    Pagamentos.Add(novoPagamento);
        //    return CreatedAtAction(nameof(ListarPorId), new { id = novoPagamento.IdPagamento }, novoPagamento);

        //}

        //[HttpPut]




        private readonly ILogger<PagamentoController> _logger;

        public PagamentoController(ILogger<PagamentoController> logger)
        {
            _logger = logger;
        }

    }
}
