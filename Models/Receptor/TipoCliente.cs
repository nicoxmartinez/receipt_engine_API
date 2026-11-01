using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Receptor;

[Table("TIPO_CLIENTE")]
public class TipoCliente
{
    [Key]
    [Column("ID_TIPO_CLIENTE")]
    public int Id { get; set; }

    [Required]
    [Column("NOMBRE")]
    public string Nombre { get; set; }

}
