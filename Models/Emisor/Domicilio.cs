using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receipt_engine_API.Models.Emisor;

[Table("DOMICILIO")]
[Serializable]
public class Domicilio
{
    [Key]
    [Column("ID_DOMICILIO")]
    public long IdDomicilio { get; set; }

    [Required]
    [Column("CALLE")]
    public string Calle { get; set; }

    [Required]
    [Column("NUMERO")]
    public int Numero { get; set; }

    [Required]
    [Column("LOCALIDAD")]
    public string Localidad { get; set; }

    [Required]
    [Column("PARTIDO")]
    public string Partido { get; set; }

    [Column("CODIGO_POSTAL")]
    public string? CodigoPostal { get; set; }

    [Column("ENTRE_CALLES")]
    public string? EntreCalles { get; set; }

    [Required]
    [Column("PROVINCIA")]
    public string Provincia { get; set; }

    [Required]
    [Column("PAIS")]
    public string Pais { get; set; }

    public Domicilio(string calle, int numero, string localidad, string partido, string? codigoPostal, string? entreCalles, string provincia, string pais)
    {
        Calle = calle;
        Numero = numero;
        Localidad = localidad;
        Partido = partido;
        CodigoPostal = codigoPostal;
        EntreCalles = entreCalles;
        Provincia = provincia;
        Pais = pais;
    }

}