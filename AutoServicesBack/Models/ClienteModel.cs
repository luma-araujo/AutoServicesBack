using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AutoServicesBack.Models
{
    public class Cliente
    {
        public string? RequestId { get; set; }

        [DisplayName("ID")]
        public int IdCliente { get; set; }
        [Required]

        [DisplayName("Nome")]
        public string? Nome { get; set; }
        [Required]

        [DisplayName("Telefone")]
        public string? Telefone { get; set; }
        [Required]

        [DisplayName("Email")]
        public string? Email { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
