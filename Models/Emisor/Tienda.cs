using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Emisor;

[Table("TIENDA")]
[Serializable]
public class Tienda
{
    [Key]
    [Column("ID_TIENDA")]
    public int IdTienda { get; set; }
    [Required]
    [Column("CODIGO")]
    public string Codigo { get; set; }
    [Required]
    [Column("DESCRIPCION")]
    public string Descripcion { get; set; }
    [Required]
    [Column("TIPO_TIENDA")]
    public TipoTienda TipoTienda { get; set; }
    [Required]
    [Column("USUARIO")]
    public string Usuario { get; set; }
    [Required]
    [Column("FECHA_ALTA")]
    public DateTime FechaAlta { get; set; }

    public Tienda(string codigo, string descripcion, TipoTienda tipoTienda, string usuario, DateTime fechaAlta)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        TipoTienda = tipoTienda;
        Usuario = usuario;
        FechaAlta = fechaAlta;
    }

}