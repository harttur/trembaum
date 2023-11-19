using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TremBaum.Models
{
    [Table("Produto")]
    public class Produto

    {
        [Key]
        [Display(Name="Id")]
        public string Id_produto { get; set; }

        public string Nome { get; set; }

  
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        public string Foto { get; set; }
        
    }
}
