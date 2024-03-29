using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Estoque")]
public class Estoque
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "ProdutoId")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
     public Produto Produto { get; set; }

    [Display(Name = "Tamanho")]
    [Required(ErrorMessage = "Por favor, informe o tamanho")]
    public int TamanhoId { get; set; }
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho { get; set; }

    [Display(Name = "Cor")]
    [Required(ErrorMessage = "Informe a cor")]
    public int CorId { get; set; }
    [ForeignKey("CorId")]
    public Cor Cor { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")] //99.999.999,99
    public decimal? Preco { get; set; }

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(10,2)")] //99.999.999,99
    public decimal? PrecoDesconto { get; set; }

    [Display(Name = "Qtde em Estoque")]
    [Required(ErrorMessage = "Por favor, informe a Qtde em Estoque")]
    public int Qtde { get; set; } = 0;
}
