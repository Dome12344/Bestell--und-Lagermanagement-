using System;
using System.Collections.Generic;

namespace Bestell__und_Lagermanagement.model
{
    public partial class Bestellung
    {
        public int Bestellnummer { get; set; }
        public string? BestellungBezeichung { get; set; }
        public int? Anzahl { get; set; }
        public int? Lieferantennummer { get; set; }
        public string? Bestelldatum { get; set; }
        public string? Lagerort { get; set; }
        public string? BestellStatus { get; set; }
        public int? Mitarbeiternummer { get; set; }
    }
}
