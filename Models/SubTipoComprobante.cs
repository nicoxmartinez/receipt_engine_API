using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models;

[Table("SUBTIPO_COMPROBANTE")]
public class SubTipoComprobante
{
    [Key]
    public int IdSubTipoComprobante { get; set; }
    [Required]
    [MaxLength(5)]
    public string Codigo { get; set; }
}