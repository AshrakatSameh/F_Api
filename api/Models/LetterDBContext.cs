using System;
using System.Collections.Generic;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api
{
    public partial class LetterDBContext : DbContext
    {
        public LetterDBContext()
        {
        }

        public LetterDBContext(DbContextOptions<LetterDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Depts { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<Exletter> Exletters { get; set; } = null!;
        public virtual DbSet<LetterEx> Letterices { get; set; } = null!;
        public virtual DbSet<LetterView> LetterViews { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<MainEx> Mainices { get; set; } = null!;
        public virtual DbSet<MainLetter> MainLetters { get; set; } = null!;
        public virtual DbSet<Side> Sides { get; set; } = null!;
        public virtual DbSet<SubEx> Subices { get; set; } = null!;
        public virtual DbSet<SubLetter> SubLetters { get; set; } = null!;
        public virtual DbSet<ViewEx> Viewices { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LetterDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>(entity =>
            {
                entity.ToTable("Dept");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(250)
                    .HasColumnName("Dept_Name");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Ser);

                entity.ToTable("Emp");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Exletter>(entity =>
            {
                entity.HasKey(e => e.Ser);

                entity.ToTable("Exletter");

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateout)
                    .HasColumnType("date")
                    .HasColumnName("dateout");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Noout)
                    .HasMaxLength(50)
                    .HasColumnName("noout");

                entity.Property(e => e.Noout2)
                    .HasMaxLength(11)
                    .HasColumnName("noout2");

                entity.Property(e => e.Noprevletter)
                    .HasMaxLength(50)
                    .HasColumnName("noprevletter");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome).HasColumnName("sidecome");

                entity.Property(e => e.Sideout)
                    .HasMaxLength(50)
                    .HasColumnName("sideout");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");

                entity.HasOne(d => d.Noout2Navigation)
                    .WithMany(p => p.Exletters)
                    .HasForeignKey(d => d.Noout2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exletter_MainLetter1");
            });

            modelBuilder.Entity<LetterEx>(entity =>
            {
                entity.HasKey(e => e.Ser)
                    .HasName("PK_Table1");

                entity.ToTable("LetterEX");

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateout)
                    .HasColumnType("date")
                    .HasColumnName("dateout");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Noletter).HasMaxLength(11);

                entity.Property(e => e.Noout)
                    .HasMaxLength(50)
                    .HasColumnName("noout");

                entity.Property(e => e.Noout1).HasColumnName("noout1");

                entity.Property(e => e.Noprevletter)
                    .HasMaxLength(50)
                    .HasColumnName("noprevletter");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome).HasColumnName("sidecome");

                entity.Property(e => e.Sideout)
                    .HasMaxLength(50)
                    .HasColumnName("sideout");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");

                entity.HasOne(d => d.NoletterNavigation)
                    .WithMany(p => p.Letterices)
                    .HasForeignKey(d => d.Noletter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LetterEX_MainEX1");
            });

            modelBuilder.Entity<LetterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LetterView");

                entity.Property(e => e.Code).HasMaxLength(11);

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Expr2).HasColumnType("date");

                entity.Property(e => e.Expr3).HasColumnType("date");

                entity.Property(e => e.Expr7).HasMaxLength(50);

                entity.Property(e => e.Expr8).HasMaxLength(50);

                entity.Property(e => e.Nletter).HasMaxLength(11);

                entity.Property(e => e.Noletter).HasColumnName("noletter");

                entity.Property(e => e.Noout1).HasColumnName("noout1");

                entity.Property(e => e.Noout2)
                    .HasMaxLength(11)
                    .HasColumnName("noout2");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome)
                    .HasMaxLength(50)
                    .HasColumnName("sidecome");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<MainEx>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("MainEX");

                entity.Property(e => e.Code).HasMaxLength(11);

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasColumnName("dateIn");

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Datefolow)
                    .HasColumnType("date")
                    .HasColumnName("datefolow");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NoIn).HasColumnName("noIn");

                entity.Property(e => e.Noletter).HasColumnName("noletter");

                entity.Property(e => e.Noout1)
                    .HasMaxLength(50)
                    .HasColumnName("noout1");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.SideIn)
                    .HasMaxLength(50)
                    .HasColumnName("sideIn");

                entity.Property(e => e.Sidecome)
                    .HasMaxLength(50)
                    .HasColumnName("sidecome");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");
            });

            modelBuilder.Entity<MainLetter>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_MainLetter_1");

                entity.ToTable("MainLetter");

                entity.Property(e => e.Code).HasMaxLength(11);

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Datefolow)
                    .HasColumnType("date")
                    .HasColumnName("datefolow");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateout)
                    .HasColumnType("date")
                    .HasColumnName("dateout");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Dept).HasMaxLength(250);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Noletter).HasColumnName("noletter");

                entity.Property(e => e.Noout).HasColumnName("noout");

                entity.Property(e => e.Noout1)
                    .HasMaxLength(50)
                    .HasColumnName("noout1");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome)
                    .HasMaxLength(50)
                    .HasColumnName("sidecome");

                entity.Property(e => e.Sideout)
                    .HasMaxLength(50)
                    .HasColumnName("sideout");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");
            });

            modelBuilder.Entity<Side>(entity =>
            {
                entity.HasKey(e => e.Ser);

                entity.ToTable("Side");

                entity.Property(e => e.Ser).ValueGeneratedNever();

                entity.Property(e => e.Side1)
                    .HasMaxLength(50)
                    .HasColumnName("Side");
            });

            modelBuilder.Entity<SubEx>(entity =>
            {
                entity.HasKey(e => e.Ser);

                entity.ToTable("SubEX");

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateout)
                    .HasColumnType("date")
                    .HasColumnName("dateout");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Noletter).HasMaxLength(11);

                entity.Property(e => e.Noout)
                    .HasMaxLength(50)
                    .HasColumnName("noout");

                entity.Property(e => e.Noout1).HasColumnName("noout1");

                entity.Property(e => e.Noprevletter)
                    .HasMaxLength(11)
                    .HasColumnName("noprevletter");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome).HasColumnName("sidecome");

                entity.Property(e => e.Sideout)
                    .HasMaxLength(50)
                    .HasColumnName("sideout");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");

                entity.HasOne(d => d.NoletterNavigation)
                    .WithMany(p => p.Subices)
                    .HasForeignKey(d => d.Noletter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubEX_MainEX1");
            });

            modelBuilder.Entity<SubLetter>(entity =>
            {
                entity.HasKey(e => e.Ser);

                entity.ToTable("SubLetter");

                entity.Property(e => e.DateMode).HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadd");

                entity.Property(e => e.Datecome)
                    .HasColumnType("date")
                    .HasColumnName("datecome");

                entity.Property(e => e.Dateletter)
                    .HasColumnType("date")
                    .HasColumnName("dateletter");

                entity.Property(e => e.Datemod)
                    .HasColumnType("datetime")
                    .HasColumnName("datemod");

                entity.Property(e => e.Dateout)
                    .HasColumnType("date")
                    .HasColumnName("dateout");

                entity.Property(e => e.Dateprevletter)
                    .HasColumnType("date")
                    .HasColumnName("dateprevletter");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Nletter).HasMaxLength(11);

                entity.Property(e => e.Noout)
                    .HasMaxLength(50)
                    .HasColumnName("noout");

                entity.Property(e => e.Noout1).HasColumnName("noout1");

                entity.Property(e => e.Noprevletter)
                    .HasMaxLength(11)
                    .HasColumnName("noprevletter");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Recevied)
                    .HasMaxLength(50)
                    .HasColumnName("recevied");

                entity.Property(e => e.Respons)
                    .HasMaxLength(50)
                    .HasColumnName("respons");

                entity.Property(e => e.Sidecome).HasColumnName("sidecome");

                entity.Property(e => e.Sideout)
                    .HasMaxLength(50)
                    .HasColumnName("sideout");

                entity.Property(e => e.Useradd)
                    .HasMaxLength(50)
                    .HasColumnName("useradd");

                entity.Property(e => e.Usermod)
                    .HasMaxLength(50)
                    .HasColumnName("usermod");

                entity.HasOne(d => d.NletterNavigation)
                    .WithMany(p => p.SubLetters)
                    .HasForeignKey(d => d.Nletter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubLetter_MainLetter1");
            });

            modelBuilder.Entity<ViewEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewEX");

                entity.Property(e => e.Noout1).HasColumnName("noout1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
