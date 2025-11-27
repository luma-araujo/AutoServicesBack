using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Usuario
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Usuário")]
        public int IdUsuario { get; set; }

        [DisplayName("Nome de Usuário")]
        public string? Nome { get; set; }
        [Required]

        [DisplayName("Tipo de Usuário")]
        public string? Tipo { get; set; }
        [Required]

        [DisplayName("Telefone")]
        public string? Telefone { get; set; }
        [Required]

        [DisplayName("Email")]  
        public string? Email { get; set; }

        [DisplayName("Senha")]
        public string? Senha { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
