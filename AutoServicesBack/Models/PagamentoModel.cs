using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Pagamento
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Pagamento")]
        public int IdPagamento { get; set; }
        [Required]

        [DisplayName("ID Ordem de Serviço")]
        public int IdOrdemServico { get; set; }
        [Required]

        [DisplayName("Valor Total")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Data do Pagamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataPagamento { get; set; }

        [DisplayName("Forma de Pagamento")]
        public string? FormaPagamento { get; set; }

        [DisplayName("Status do Pagamento")]
        public string? StatusPagamento { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    
    }
}
