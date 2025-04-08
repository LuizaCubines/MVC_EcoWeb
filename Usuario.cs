

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecoweb.Models{

[Table("Usuario")]
public class Usuario
   {
    [Key]
    [Column("id")]
    [Display(Name = "id")]
    public int id { get; set;}
    [Column("Nome")]
    [Display(Name = "Nome")]
    public string Nome {get; set;}
    [Column("Cpf")]
    [Display(Name = "Cpf")]
    public string Cpf {get; set;}
    [Column("Email")]
    [Display(Name = "Email")]
    public string Email {get; set;}
    [Column("Senha")]
    [Display(Name = "Senha")]
    public string Senha {get; set;}
    }
}