using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Application.Models
{
    public class Mammals : Animal
    {
        public bool Trainable { get; set; }
        public bool HasAVaccination { get; set; }
    }
}