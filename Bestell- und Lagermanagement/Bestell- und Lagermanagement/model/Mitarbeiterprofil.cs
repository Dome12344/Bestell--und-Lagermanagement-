using System;
using System.Collections.Generic;

namespace Bestell__und_Lagermanagement.model
{
    public partial class Mitarbeiterprofil
    {
        public int Mitarbeiternummer { get; set; }
        public string? Benutzername { get; set; }
        public string? Passwort { get; set; }
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public string? EMail { get; set; }
        public string? Telefon { get; set; }
        public string? Diensthandy { get; set; }
    }
}
