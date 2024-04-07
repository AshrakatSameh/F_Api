namespace api.Dtos
{
    public class MainLetterDto
    {
        public int Noletter { get; set; }
        public DateTime Datecome { get; set; }
        public string Code { get; set; } = null!;
        public string? Sidecome { get; set; }
        public DateTime? Dateletter { get; set; }
        public string? Description { get; set; }
        public string? Respons { get; set; }
        public string? Dept { get; set; }
        public DateTime? Datefolow { get; set; }
        public int? Noout { get; set; }
        public DateTime? Dateout { get; set; }
        public string? Sideout { get; set; }
        public string? Recevied { get; set; }
        public string? Notes { get; set; }
        public string? Noout1 { get; set; }
        public DateTime? Dateprevletter { get; set; }
        public string? Useradd { get; set; }
        public DateTime? Dateadd { get; set; }
        public string? Usermod { get; set; }
        public DateTime? Datemod { get; set; }
        public DateTime? DateMode { get; set; }
    }
}
