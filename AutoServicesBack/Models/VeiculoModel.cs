using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Veiculo
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Veículo")]
        public int IdVeiculo { get; set; }
        [Required]

        [DisplayName("Modelo")]
        public string? Modelo { get; set; }
        [Required]

        [DisplayName("Marca")]
        public string? Marca { get; set; }
        [Required]

        [DisplayName("Ano")]
        public int Ano { get; set; }

        [DisplayName("Placa")]
        public string? Placa { get; set; }
        [Required]

        [DisplayName("ID Cliente")]
        public int IdCliente { get; set; }
        [Required]

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
