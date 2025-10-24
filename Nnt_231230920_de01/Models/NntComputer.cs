using System;
using System.Collections.Generic;

namespace Nnt_231230920_de01.Models;

public partial class NntComputer
{
    public string NntComId { get; set; } = null!;

    public string NntComName { get; set; } = null!;

    public decimal NntComPrice { get; set; }

    public string? NntComImage { get; set; }

    public bool? NntComStatus { get; set; }
}
