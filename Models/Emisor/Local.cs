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

    public Local(string codigo, string descripcion, TipoTienda tipoTienda, string usuario, DateTime fechaAlta, Domicilio domicilio) : base(codigo, descripcion, tipoTienda, usuario, fechaAlta)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        TipoTienda = tipoTienda;
        Usuario = usuario;
        FechaAlta = fechaAlta;
        Domicilio = domicilio;
    }
}