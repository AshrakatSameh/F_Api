﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LetterDBEntities : DbContext
    {
        public LetterDBEntities()
            : base("name=LetterDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Exletter> Exletters { get; set; }
        public virtual DbSet<LetterEX> LetterEXes { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MainEX> MainEXes { get; set; }
        public virtual DbSet<MainLetter> MainLetters { get; set; }
        public virtual DbSet<Side> Sides { get; set; }
        public virtual DbSet<SubEX> SubEXes { get; set; }
        public virtual DbSet<SubLetter> SubLetters { get; set; }
    }
}
