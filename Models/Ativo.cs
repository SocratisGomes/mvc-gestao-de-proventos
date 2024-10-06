using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_gestao_de_proventos.Models
{
    [Table("Ativos")]
    public class Ativo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ticker!")]
        public string Ticker { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o segmento!")]
        public string Segmento { get; set; }
    }
}