using System;
using System.Collections.Generic;

namespace books.Models.Entities;

public partial class Yayinevleri
{
    public int Id { get; set; }

    public string YayineviAdi { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public int Sira { get; set; }
}
