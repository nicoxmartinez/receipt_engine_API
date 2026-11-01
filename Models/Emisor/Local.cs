using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Emisor;

[Table("LOCAL")]
[Serializable]
public class Local : Tienda
{
    [Required]
    [Column("ID_DOMICILIO")]
    public Domicilio Domicilio { get; set; }

    public Local(Domicilio domicilio)
    {
        Domicilio = domicilio;
    }
}