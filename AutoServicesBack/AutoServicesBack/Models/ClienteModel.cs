using System.ComponentModel;

namespace AutoServices.Models
{
    public class ClienteModel
    {
        public string? RequestId { get; set; }

        [DisplayName("ID")]
        public int IdCliente { get; set; }

        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [DisplayName("Telefone")]
        public string? Telefone { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
