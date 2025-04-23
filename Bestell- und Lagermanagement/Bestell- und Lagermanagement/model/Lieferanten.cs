using System;
using System.Collections.Generic;

namespace Bestell__und_Lagermanagement.model
{
    public partial class Lieferanten
    {
        public int Lieferantennummer { get; set; }
        public string? FrimenName { get; set; }
        public string? FirmenSitze { get; set; }
        public decimal? Preis { get; set; }
        public string? Lieferzeit { get; set; }
        public string? WelcheWarensindverfuegbar { get; set; }
        public int? Mitarbeiternummer { get; set; }
    }
}
