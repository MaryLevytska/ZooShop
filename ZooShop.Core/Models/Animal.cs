using System;
using System.Collections.Generic;
using ZooShop.Core.Enums;

namespace ZooShop.Core.Models;

public partial class Animal
{
    public Guid Id { get; set; }

    public byte Type { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public bool? FastSwimming { get; set; }

    public double Height { get; set; }
    public double Weight { get; set; }
    public Breed Breed { get; set; }
    public string Img { get; set; }
    public Cover Cover { get; set; }
    public Age Age { get; set; }
    public BloodTypes BloodTypes { get; set; }
    public Function[] Functions { get; set; }


    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}
