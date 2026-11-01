using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models;

[Table("TIPO_COMPROBANTE")]
public class TipoComprobante
{
    [Key]
    public int IdTipoComprobante { get; set; }
    [Required]
    [MaxLength(20)]
    public string Nombre { get; set; }
}   