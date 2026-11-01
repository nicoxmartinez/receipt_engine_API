namespace receipt_engine_API.Models.Emisor;

public enum TipoTienda
{
   FISICA,
   VIRTUAL
}

public static class TipoTiendaExtensions
{
   public static string GetDescripcion(this TipoTienda tipo) =>
       tipo switch
       {
           TipoTienda.FISICA => "Tienda Física",
           TipoTienda.VIRTUAL => "Tienda Virtual",
             _ => throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null)
       };
}