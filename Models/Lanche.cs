using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Display(Name = "O nome do lanche")]
    [Required(ErrorMessage = "{0} deve ser informado.")]
    [MinLength(10, ErrorMessage = "{0} deve ter no mínimo {1} caracteres.")]
    [MaxLength(80, ErrorMessage = "{0} ter no máximo {1} caracteres.")]
    public string Nome { get; set; }

    [Display(Name = "A descrição do lanche")]
    [Required(ErrorMessage = "{0} deve ser informada.")]
    [MinLength(20, ErrorMessage = "{0} deve ter no mínimo {1} caracteres.")]
    [MaxLength(100, ErrorMessage = "{0} ter no máximo {1} caracteres.")]
    public string DescricaoCurta { get; set; }

    [Display(Name = "A descrição detalhada do lanche")]
    [Required(ErrorMessage = "{0} deve ser informada.")]
    [MinLength(40, ErrorMessage = "{0} deve ter no mínimo {1} caracteres.")]
    [MaxLength(300, ErrorMessage = "{0} ter no máximo {1} caracteres.")]
    public string DescricaoDetalhada { get; set; }

    [Display(Name = "O preço do lanche")]
    [Required(ErrorMessage = "{0} deve ser informado.")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage = "{0} deve estar entre {1} e {2}.")]
    public decimal Preco { get; set; }

    [Display(Name = "O caminho da imagem")]
    [MaxLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres.")]
    public string ImagemUrl { get; set; }

    [Display(Name = "O caminho da miniatura")]
    [MaxLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres.")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Lanche preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Lanche em estoque?")]
    public bool EmEstoque { get; set; }


    //Relacionamento Lanche-Categoria (1 para 1)
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
}
