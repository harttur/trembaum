using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TremBaum.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Key]
        public int Id_Estoque { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório informar quantidade!")]
        public string Quantidade { get; set; }

        public double Preco { get; set; }

    }
}
