using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TremBaum.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id_Usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço!")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Telefone { get; set;}

        public Funcao Funcao { get; set; }
    }

    public enum Funcao
    {
        User,
        Admin
    }
}
