using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using receipt_engine_API.Models.Emisor;

namespace receipt_engine_API.Models.Comprobantes;

[Table("PUNTOS_DE_VENTA")]
[Serializable]
public class PuntoDeVenta
{
    [Key]
    [Column("ID_PUNTO_DE_VENTA")]
    public int IdPuntoDeVenta { get; set; }

    [Required]
    [Column("NUMERO_TERMINAL")]
    public int NumeroTerminal { get; set; }

    [Required]
    [Column("NOMBRE_TERMINAL")]
    public string NombreTerminal { get; set; }

    [Required]
    [Column("NUMERO_CAJA")]
    public short NumeroCaja { get; set; }

    [Required]
    [Column("ID_Tienda")]
    public Local Local { get; set; }

    public PuntoDeVenta(int numeroTerminal, string nombreTerminal, short numeroCaja, Local local)
    {
        NumeroTerminal = numeroTerminal;
        NombreTerminal = nombreTerminal;
        NumeroCaja = numeroCaja;
        Local = local;
    }
}