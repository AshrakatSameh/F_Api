using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class MainEx
    {
        public MainEx()
        {
            Letterices = new HashSet<LetterEx>();
            Subices = new HashSet<SubEx>();
        }

        public int Id { get; set; }
        public int Noletter { get; set; }
        public DateTime Datecome { get; set; }
        public string Code { get; set; } = null!;
        public string? Sidecome { get; set; }
        public DateTime? Dateletter { get; set; }
        public string? Description { get; set; }
        public string? Respons { get; set; }
        public DateTime? Datefolow { get; set; }
        public int? NoIn { get; set; }
        public DateTime? DateIn { get; set; }
        public string? SideIn { get; set; }
        public string? Recevied { get; set; }
        public string? Notes { get; set; }
        public string? Noout1 { get; set; }
        public DateTime? Dateprevletter { get; set; }
        public string? Useradd { get; set; }
        public DateTime? Dateadd { get; set; }
        public string? Usermod { get; set; }
        public DateTime? Datemod { get; set; }
        public DateTime? DateMode { get; set; }

        public virtual ICollection<LetterEx> Letterices { get; set; }
        public virtual ICollection<SubEx> Subices { get; set; }
    }
}
