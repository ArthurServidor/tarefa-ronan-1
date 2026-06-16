using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tarefa_ronan_1.Produto;

[Table("produtos")]
public class Produto
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Column("descricao")]
    public string? Descricao { get; set; }

    [Column("preco")]
    public decimal Preco { get; set; }

    [Column("categoria")]
    public string? Categoria { get; set; }

    [Column("criado_em")]
    public DateTime CriadoEm { get; set; } = DateTime.Now;
}
