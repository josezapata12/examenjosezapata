// Models/Smartphone.cs
namespace InventarioBlazorApp.Models
{
    public class Smartphone : Dispositivo
    {
        public string? SistemaOperativo { get; set; }
        public int NumeroDeCamaras { get; set; }
    }
}
