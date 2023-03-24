using System;
using System.Collections.Generic;

namespace books.Models.Entities;

public partial class Turler
{
    public int Id { get; set; }

    public string TurAdi { get; set; } = null!;

    public int Sira { get; set; }
}
