using System;
using System.Collections.Generic;

namespace books.Models.Entities;

public partial class Kitaplar
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public int YazarId { get; set; }

    public int DilId { get; set; }

    public int SayfaSayisi { get; set; }

    public int YayineviId { get; set; }

    public string Ozet { get; set; } = null!;

    public DateOnly YayinTarihi { get; set; }

    public string? Resim { get; set; }
}
