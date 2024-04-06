using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Pass { get; set; }
        public string? Role { get; set; }
    }
}
