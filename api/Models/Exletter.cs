using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Exletter
    {
        public int Ser { get; set; }
        public string Noout2 { get; set; } = null!;
        public int? Noletter { get; set; }
        public DateTime? Datecome { get; set; }
        public string? Sidecome { get; set; }
        public DateTime? Dateletter { get; set; }
        public string? Description { get; set; }
        public string? Respons { get; set; }
        public string? Noprevletter { get; set; }
        public DateTime? Dateprevletter { get; set; }
        public string? Noout { get; set; }
        public DateTime? Dateout { get; set; }
        public string? Sideout { get; set; }
        public string? Recevied { get; set; }
        public string? Notes { get; set; }
        public string? Useradd { get; set; }
        public DateTime? Dateadd { get; set; }
        public string? Usermod { get; set; }
        public DateTime? Datemod { get; set; }
        public DateTime? DateMode { get; set; }

        public virtual MainLetter Noout2Navigation { get; set; } = null!;
    }
}
