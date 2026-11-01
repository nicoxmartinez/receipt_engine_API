using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using receipt_engine_API.Models.Emisor;
using receipt_engine_API.Models.Receptor;

namespace receipt_engine_API.Models.Comprobantes;

[Table("COMPROBANTE")]
public abstract class Comprobante
{
    [Key]
    [Column("ID_COMPROBANTE")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdComprobante { get; set; }

    [Required]
    [Column("ID_TIPO_COMPROBANTE")]
    public TipoComprobante TipoComprobante { get; set; }

    [Required]
    [Column("ID_SUBTIPO_COMPROBANTE")]
    public SubTipoComprobante SubTipoComprobante { get; set; }

    [Required]
    [Column("FECHA_EMISION")]
    public DateTime FechaEmision { get; set; }

    // Datos de Emisor
    [Required]
    [Column("ID_PUNTO_DE_VENTA")]
    public PuntoDeVenta PuntoDeVenta { get; set; }

    //Datos de Receptor
    [Required]
    [Column("ID_CLIENTE")]
    public Cliente Cliente { get; set; }

    [Required]
    [Column("MONTO_TOTAL")]
    public decimal MontoTotal { get; set; }

}