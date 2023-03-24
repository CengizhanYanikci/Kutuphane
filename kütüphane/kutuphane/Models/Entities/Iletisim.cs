using System;
using System.Collections.Generic;

namespace books.Models.Entities;

public partial class Iletisim
{
    public int Id { get; set; }

    public string Eposta { get; set; } = null!;

    public string Konu { get; set; } = null!;

    public string Mesaj { get; set; } = null!;

    public DateTime TarihSaat { get; set; }

    public string Ip { get; set; } = null!;

    public bool Goruldu { get; set; }
}
