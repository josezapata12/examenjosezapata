// Models/Laptop.cs
namespace InventarioBlazorApp.Models
{
    public class Laptop : Dispositivo
    {
        public int MemoriaRAM { get; set; } // en GB
        public int Almacenamiento { get; set; } // en GB
    }
}
