using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoServices.Models
{
    public class Ordem_ServicoModel
    {
        public string? RequestId { get; set; }

        [DisplayName("ID Ordem de Servi�o")]
        public int Id { get; set; }

        [DisplayName("ID Cliente")]
        public int IdCliente { get; set; }

        [DisplayName("ID Ve�culo")]
        public int IdVeiculo { get; set; }

        [DisplayName("Descri��o do Problema")]
        public string? DescricaoProblema { get; set; }

        [DisplayName("Data de Abertura")]
       
        public DateTime DataAbertura { get; set; }

        [DisplayName("Status de Servi�o")]
        public string? StatusServico { get; set; }

        [DisplayName("ID Mec�nico")]
        public int? IdMecanico { get; set; }

        [DisplayName("Diagn�stico")]
        public string? Diagnostico { get; set; }

        [DisplayName("Procedimento Realizado")]
        public string? ProcedimentoRealizado { get; set; }



        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
