using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Peca
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Peça")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string? Nome { get; set; }
        [Required]

        [DisplayName("Preço Unitário")]
        public decimal PrecoUnitario { get; set; }

        [DisplayName("Quantidade em Estoque")]
        public int QuantidadeEstoque { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
