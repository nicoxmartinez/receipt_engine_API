using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Receptor;

[Table("TIPO_DOCUMENTO")]
public class TipoDocumento
{
    [Key]
    [Column("ID_TIPO_DOCUMENTO")]
    public int Id { get; set; }

    [Required]
    [Column("CODIGO")]
    public string Codigo { get; set; }

    [Required]
    [Column("DESCRIPCION")]
    public string Descripcion { get; set; }

    public TipoDocumento(string codigo, string descripcion)
    {
        Codigo = codigo;
        Descripcion = descripcion;
    }
}