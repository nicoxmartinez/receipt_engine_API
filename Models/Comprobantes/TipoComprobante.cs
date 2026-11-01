using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Comprobantes;

[Table("TIPO_COMPROBANTE")]
public class TipoComprobante
{
    [Key]
    [Column("ID_TIPO_COMPROBANTE")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTipoComprobante { get; set; }
    [Required]
    [Column("NOMBRE")]
    [MaxLength(20)]
    public string Nombre { get; set; }

    public TipoComprobante(string nombre)
    {
        Nombre = nombre;
    }
}   