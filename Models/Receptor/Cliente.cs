using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Receptor;

[Table("CLIENTE")]
public class Cliente
{
    [Key]
    [Column("ID_CLIENTE")]
    public long IdCliente { get; set; }

    [Required]
    [Column("NOMBRE")]
    public string Nombre { get; set; }

    [Required]
    [Column("ID_TIPO_CLIENTE")]
    public TipoCliente TipoCliente { get; set; }
    
    [Required]
    [Column("ID_TIPO_DOCUMENTO")]
    public TipoCliente TipoDocumento { get; set; }

    [Required]
    [Column("DOCUMENTO")]
    public string Documento { get; set; }

    public Cliente(string nombre, TipoCliente tipoCliente, TipoCliente tipoDocumento, string documento)
    {
        Nombre = nombre;
        TipoCliente = tipoCliente;
        TipoDocumento = tipoDocumento;
        Documento = documento;
    }

}