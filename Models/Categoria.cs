using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Display(Name = "O nome da categoria")]
    [Required(ErrorMessage = "{0} deve ser informado.")]
    [MaxLength(100, ErrorMessage = "{0} deve ter no máximo {1} caracteres.")]
    public string Nome { get; set; }

    [Display(Name = "A descrição da categoria")]
    [Required(ErrorMessage = "{0} deve ser informada.")]
    [MaxLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres.")]
    public string Descricao { get; set; }

    //Relacionamento Categoria-Lanche(s) (1 para muitos)
    public List<Lanche> Lanches { get; set; }
}
