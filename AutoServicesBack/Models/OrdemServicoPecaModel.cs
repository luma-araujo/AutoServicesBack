using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Ordem_Servico_Peca
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Ordem de Serviço")]
        public int IdOrdemServico { get; set; }
        [Required]

        [DisplayName("ID Peça")]
        public int IdPeca { get; set; }

        [DisplayName("Quantidade Utilizada")]
        public int QuantidadeUtilizada { get; set; }
        [Required]

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
