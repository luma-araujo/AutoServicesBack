using System.ComponentModel;

namespace AutoServicesBack.Models
{
    public class Usuario
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Usu�rio")]
        public int Id { get; set; }

        [DisplayName("Nome de Usu�rio")]
        public string? Nome { get; set; }

        [DisplayName("Tipo de Usu�rio")]
        public string? Tipo { get; set; }

        [DisplayName("Telefone")]
        public string? Telefone { get; set; }

        [DisplayName("Email")]  
        public string? Email { get; set; }

        [DisplayName("Senha")]
        public string? Senha { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
