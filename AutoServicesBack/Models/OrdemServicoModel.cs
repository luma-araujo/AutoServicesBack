using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServicesBack.Models
{
    public class Ordem_Servico
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Ordem de Serviço")]
        public int Id { get; set; }
        [Required]

        [DisplayName("ID Cliente")]
        public int IdCliente { get; set; }
        [Required]

        [DisplayName("ID Veículo")]
        public int IdVeiculo { get; set; }
        [Required]

        [DisplayName("Descrição do Problema")]
        public string? DescricaoProblema { get; set; }
        [Required]

        [DisplayName("Data de Abertura")]
        public DateTime DataAbertura { get; set; }

        [DisplayName("Status de Serviço")]
        public string? StatusServico { get; set; }

        [DisplayName("ID Mecânico")]
        public int? IdMecanico { get; set; }

        [DisplayName("Diagnóstico")]
        public string? Diagnostico { get; set; }

        [DisplayName("Procedimento Realizado")]
        public string? ProcedimentoRealizado { get; set; }



        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
