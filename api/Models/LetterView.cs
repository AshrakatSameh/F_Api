using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class LetterView
    {
        public int Noletter { get; set; }
        public DateTime Datecome { get; set; }
        public string Code { get; set; } = null!;
        public string? Sidecome { get; set; }
        public DateTime? Dateletter { get; set; }
        public string? Description { get; set; }
        public string? Respons { get; set; }
        public string? Recevied { get; set; }
        public string? Notes { get; set; }
        public string Noout2 { get; set; } = null!;
        public int? Expr1 { get; set; }
        public DateTime? Expr2 { get; set; }
        public string? Expr4 { get; set; }
        public string Nletter { get; set; } = null!;
        public int? Noout1 { get; set; }
        public DateTime? Expr3 { get; set; }
        public string? Expr5 { get; set; }
        public string? Expr6 { get; set; }
        public string? Expr7 { get; set; }
        public string? Expr8 { get; set; }
        public string? Expr9 { get; set; }
    }
}
