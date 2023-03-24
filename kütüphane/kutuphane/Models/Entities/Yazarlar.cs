using System;
using System.Collections.Generic;

namespace books.Models.Entities;

public partial class Yazarlar
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public DateOnly DogumTarihi { get; set; }

    public string DogumYeri { get; set; } = null!;

    public bool Cinsiyeti { get; set; }
}
