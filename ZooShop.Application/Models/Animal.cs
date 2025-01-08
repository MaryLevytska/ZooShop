using System.ComponentModel;
using ZooShop.Application.Enums;

namespace ZooShop.Application.Models
{
    public class Animal
    {
        public uint Height { get; set; }
        public uint Weight { get; set; }
        public Breed Breed { get; set; }
        public string Img { get; set; } 
        public Cover Cover { get; set; }
        public Age Age { get; set; }
        public BloodTypes BloodTypes { get; set; }
        public double Price  { get; set; }
        public uint Id { get; set; }
        public Function[] Functions { get; set; }
    }
}
