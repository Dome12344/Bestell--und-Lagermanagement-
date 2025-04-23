using System;
using System.Collections.Generic;

namespace Bestell__und_Lagermanagement.model
{
    public partial class Materiallager
    {
        public int Lagernummer { get; set; }
        public string? MaterialWarenbezeichnung { get; set; }
        public string? Laenge { get; set; }
        public string? Breite { get; set; }
        public string? Hoehe { get; set; }
        public int? Anzahl { get; set; }
        public int? Mindesbestand { get; set; }
        public string? Lagerort { get; set; }
        public int? Mitarbeiternummer { get; set; }
    }
}
