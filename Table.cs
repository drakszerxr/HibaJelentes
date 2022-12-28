using System;
using System.Collections.Generic;

namespace HibaJelentes;

public partial class Table
{
    public int Id { get; set; }

    public DateTime Datum { get; set; }

    public string? Irszam { get; set; }

    public string? Varos { get; set; }

    public string? Utca { get; set; }
}
