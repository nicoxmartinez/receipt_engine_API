using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Comprobantes;

[Table("SUBTIPO_COMPROBANTE")]
public class SubTipoComprobante
{
    [Key]
    [Column("ID_SUBTIPO_COMPROBANTE")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSubTipoComprobante { get; set; }
    [Required]
    [Column("TIPO")]
    [MaxLength(5)]
    public string Tipo { get; set; }

    public SubTipoComprobante(string tipo)
    {
        Tipo = tipo;
    }
}