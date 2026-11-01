using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models;

[Table("COMPROBANTE")]
public abstract class Comprobante
{
    [Key]
    public int IdComprobante { get; set; }
    [Required]
    public TipoComprobante TipoComprobante { get; set; }
    [Required]
    public SubTipoComprobante SubTipoComprobante { get; set; }
    [Required]
    public DateTime FechaEmision { get; set; }

}