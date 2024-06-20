using System;
using System.Collections.Generic;

namespace _01_DataBase.Models;

public partial class KasaTipleri
{
    public int KasaId { get; set; }

    public string? KasaTipiAdı { get; set; }

    public virtual ICollection<Araçlar> Araçlars { get; set; } = new List<Araçlar>();
}
