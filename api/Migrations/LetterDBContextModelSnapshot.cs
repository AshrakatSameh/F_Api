﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(LetterDBContext))]
    partial class LetterDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api.Models.Dept", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DeptName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Dept_Name");

                    b.HasKey("Id");

                    b.ToTable("Dept", (string)null);
                });

            modelBuilder.Entity("api.Models.Emp", b =>
                {
                    b.Property<int>("Ser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ser"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Ser");

                    b.ToTable("Emp", (string)null);
                });

            modelBuilder.Entity("api.Models.Exletter", b =>
                {
                    b.Property<int>("Ser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ser"), 1L, 1);

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime?>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateout")
                        .HasColumnType("date")
                        .HasColumnName("dateout");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int?>("Noletter")
                        .HasColumnType("int");

                    b.Property<string>("Noout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout");

                    b.Property<string>("Noout2")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("noout2");

                    b.Property<string>("Noprevletter")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noprevletter");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Sideout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideout");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Ser");

                    b.HasIndex("Noout2");

                    b.ToTable("Exletter", (string)null);
                });

            modelBuilder.Entity("api.Models.LetterEx", b =>
                {
                    b.Property<int>("Ser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ser"), 1L, 1);

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime?>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateout")
                        .HasColumnType("date")
                        .HasColumnName("dateout");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Noletter")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Noout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout");

                    b.Property<int?>("Noout1")
                        .HasColumnType("int")
                        .HasColumnName("noout1");

                    b.Property<string>("Noprevletter")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noprevletter");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Sideout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideout");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Ser")
                        .HasName("PK_Table1");

                    b.HasIndex("Noletter");

                    b.ToTable("LetterEX", (string)null);
                });

            modelBuilder.Entity("api.Models.LetterView", b =>
                {
                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int?>("Expr1")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Expr2")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Expr3")
                        .HasColumnType("date");

                    b.Property<string>("Expr4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expr5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expr6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expr7")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Expr8")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Expr9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nletter")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("Noletter")
                        .HasColumnType("int")
                        .HasColumnName("noletter");

                    b.Property<int?>("Noout1")
                        .HasColumnType("int")
                        .HasColumnName("noout1");

                    b.Property<string>("Noout2")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("noout2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sidecome");

                    b.ToView("LetterView");
                });

            modelBuilder.Entity("api.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("api.Models.MainEx", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("date")
                        .HasColumnName("dateIn");

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Datefolow")
                        .HasColumnType("date")
                        .HasColumnName("datefolow");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("NoIn")
                        .HasColumnType("int")
                        .HasColumnName("noIn");

                    b.Property<int>("Noletter")
                        .HasColumnType("int")
                        .HasColumnName("noletter");

                    b.Property<string>("Noout1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout1");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("SideIn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideIn");

                    b.Property<string>("Sidecome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Code");

                    b.ToTable("MainEX", (string)null);
                });

            modelBuilder.Entity("api.Models.MainLetter", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Datefolow")
                        .HasColumnType("date")
                        .HasColumnName("datefolow");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateout")
                        .HasColumnType("date")
                        .HasColumnName("dateout");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Dept")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Noletter")
                        .HasColumnType("int")
                        .HasColumnName("noletter");

                    b.Property<int?>("Noout")
                        .HasColumnType("int")
                        .HasColumnName("noout");

                    b.Property<string>("Noout1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout1");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Sideout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideout");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Code")
                        .HasName("PK_MainLetter_1");

                    b.ToTable("MainLetter", (string)null);
                });

            modelBuilder.Entity("api.Models.Side", b =>
                {
                    b.Property<int>("Ser")
                        .HasColumnType("int");

                    b.Property<string>("Side1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Side");

                    b.HasKey("Ser");

                    b.ToTable("Side", (string)null);
                });

            modelBuilder.Entity("api.Models.SubEx", b =>
                {
                    b.Property<int>("Ser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ser"), 1L, 1);

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime?>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateout")
                        .HasColumnType("date")
                        .HasColumnName("dateout");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Noletter")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Noout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout");

                    b.Property<int?>("Noout1")
                        .HasColumnType("int")
                        .HasColumnName("noout1");

                    b.Property<string>("Noprevletter")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("noprevletter");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Sideout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideout");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Ser");

                    b.HasIndex("Noletter");

                    b.ToTable("SubEX", (string)null);
                });

            modelBuilder.Entity("api.Models.SubLetter", b =>
                {
                    b.Property<int>("Ser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ser"), 1L, 1);

                    b.Property<DateTime?>("DateMode")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dateadd")
                        .HasColumnType("datetime")
                        .HasColumnName("dateadd");

                    b.Property<DateTime?>("Datecome")
                        .HasColumnType("date")
                        .HasColumnName("datecome");

                    b.Property<DateTime?>("Dateletter")
                        .HasColumnType("date")
                        .HasColumnName("dateletter");

                    b.Property<DateTime?>("Datemod")
                        .HasColumnType("datetime")
                        .HasColumnName("datemod");

                    b.Property<DateTime?>("Dateout")
                        .HasColumnType("date")
                        .HasColumnName("dateout");

                    b.Property<DateTime?>("Dateprevletter")
                        .HasColumnType("date")
                        .HasColumnName("dateprevletter");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Nletter")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Noout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("noout");

                    b.Property<int?>("Noout1")
                        .HasColumnType("int")
                        .HasColumnName("noout1");

                    b.Property<string>("Noprevletter")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("noprevletter");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Recevied")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recevied");

                    b.Property<string>("Respons")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("respons");

                    b.Property<string>("Sidecome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sidecome");

                    b.Property<string>("Sideout")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sideout");

                    b.Property<string>("Useradd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("useradd");

                    b.Property<string>("Usermod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("usermod");

                    b.HasKey("Ser");

                    b.HasIndex("Nletter");

                    b.ToTable("SubLetter", (string)null);
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("api.Models.ViewEx", b =>
                {
                    b.Property<int?>("Noout1")
                        .HasColumnType("int")
                        .HasColumnName("noout1");

                    b.ToView("ViewEX");
                });

            modelBuilder.Entity("api.Models.Exletter", b =>
                {
                    b.HasOne("api.Models.MainLetter", "Noout2Navigation")
                        .WithMany("Exletters")
                        .HasForeignKey("Noout2")
                        .IsRequired()
                        .HasConstraintName("FK_Exletter_MainLetter1");

                    b.Navigation("Noout2Navigation");
                });

            modelBuilder.Entity("api.Models.LetterEx", b =>
                {
                    b.HasOne("api.Models.MainEx", "NoletterNavigation")
                        .WithMany("Letterices")
                        .HasForeignKey("Noletter")
                        .IsRequired()
                        .HasConstraintName("FK_LetterEX_MainEX1");

                    b.Navigation("NoletterNavigation");
                });

            modelBuilder.Entity("api.Models.SubEx", b =>
                {
                    b.HasOne("api.Models.MainEx", "NoletterNavigation")
                        .WithMany("Subices")
                        .HasForeignKey("Noletter")
                        .IsRequired()
                        .HasConstraintName("FK_SubEX_MainEX1");

                    b.Navigation("NoletterNavigation");
                });

            modelBuilder.Entity("api.Models.SubLetter", b =>
                {
                    b.HasOne("api.Models.MainLetter", "NletterNavigation")
                        .WithMany("SubLetters")
                        .HasForeignKey("Nletter")
                        .IsRequired()
                        .HasConstraintName("FK_SubLetter_MainLetter1");

                    b.Navigation("NletterNavigation");
                });

            modelBuilder.Entity("api.Models.MainEx", b =>
                {
                    b.Navigation("Letterices");

                    b.Navigation("Subices");
                });

            modelBuilder.Entity("api.Models.MainLetter", b =>
                {
                    b.Navigation("Exletters");

                    b.Navigation("SubLetters");
                });
#pragma warning restore 612, 618
        }
    }
}