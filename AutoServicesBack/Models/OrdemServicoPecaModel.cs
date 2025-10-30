using System.ComponentModel;

namespace AutoServicesBack.Models
{
    public class Ordem_Servico_Peca
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Ordem de Servi�o")]
        public int IdOrdemServico { get; set; }

        [DisplayName("ID Pe�a")]
        public int IdPeca { get; set; }

        [DisplayName("Quantidade Utilizada")]
        public int QuantidadeUtilizada { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
