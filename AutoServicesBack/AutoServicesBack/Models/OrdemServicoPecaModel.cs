using System.ComponentModel;

namespace AutoServices.Models
{
    public class Ordem_Servico_PecaModel
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Ordem de Serviço")]
        public int IdOrdemServico { get; set; }

        [DisplayName("ID Peça")]
        public int IdPeca { get; set; }

        [DisplayName("Quantidade Utilizada")]
        public int QuantidadeUtilizada { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
