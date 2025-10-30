using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Veiculo
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Veículo")]
        public int Id { get; set; }

        [DisplayName("Modelo")]
        public string? Modelo { get; set; }

        [DisplayName("Marca")]
        public string? Marca { get; set; }

        [DisplayName("Ano")]
        public int Ano { get; set; }

        [DisplayName("Placa")]
        public string? Placa { get; set; }

        [DisplayName("ID Cliente")]
        public int IdCliente { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
