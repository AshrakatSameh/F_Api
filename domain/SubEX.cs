//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubEX
    {
        public int Ser { get; set; }
        public string Noletter { get; set; }
        public Nullable<int> noout1 { get; set; }
        public Nullable<System.DateTime> datecome { get; set; }
        public string sidecome { get; set; }
        public Nullable<System.DateTime> dateletter { get; set; }
        public string description { get; set; }
        public string respons { get; set; }
        public string noprevletter { get; set; }
        public Nullable<System.DateTime> dateprevletter { get; set; }
        public string noout { get; set; }
        public Nullable<System.DateTime> dateout { get; set; }
        public string sideout { get; set; }
        public string recevied { get; set; }
        public string notes { get; set; }
        public string useradd { get; set; }
        public Nullable<System.DateTime> dateadd { get; set; }
        public string usermod { get; set; }
        public Nullable<System.DateTime> datemod { get; set; }
        public Nullable<System.DateTime> DateMode { get; set; }
    
        public virtual MainEX MainEX { get; set; }
    }
}
