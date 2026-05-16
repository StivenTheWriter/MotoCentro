using System.ComponentModel.DataAnnotations;
namespace MotoStudio.Domain.Entities
{
    public class Moto
    {
        
        public string Brand { get; set; } = "Locin";
        public string Model { get; set; } = "Pruss";
        public string Displacement { get; set; } = "200 cc";
        public short ModelYear { get; set; }

    }
}
