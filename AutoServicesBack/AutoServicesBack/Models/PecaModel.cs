using System.ComponentModel;

namespace AutoServices.Models
{
    public class PecaModel
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Peça")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [DisplayName("Preço Unitário")]
        public decimal PrecoUnitario { get; set; }

        [DisplayName("Quantidade em Estoque")]
        public int QuantidadeEstoque { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
