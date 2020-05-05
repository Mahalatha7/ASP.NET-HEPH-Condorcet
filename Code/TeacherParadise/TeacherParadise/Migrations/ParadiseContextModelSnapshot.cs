﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeacherParadise.DAL;

namespace TeacherParadise.Migrations
{
    [DbContext(typeof(ParadiseContext))]
    partial class ParadiseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeacherParadise.Models.CConge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProfesseurID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProfesseurID");

                    b.ToTable("Conges");
                });

            modelBuilder.Entity("TeacherParadise.Models.CCoursCollectif", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentStudent")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MatieresID")
                        .HasColumnType("int");

                    b.Property<int>("MaxStudent")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProfesseurID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartHour")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MatieresID");

                    b.HasIndex("ProfesseurID");

                    b.ToTable("CoursCollectifs");
                });

            modelBuilder.Entity("TeacherParadise.Models.CCoursRemediation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndHour")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProfesseurID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartHour")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProfesseurID");

                    b.ToTable("CoursRemediations");
                });

            modelBuilder.Entity("TeacherParadise.Models.CMatieres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CProfesseurID")
                        .HasColumnType("int");

                    b.Property<string>("Niveau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CProfesseurID");

                    b.ToTable("Matieres");
                });

            modelBuilder.Entity("TeacherParadise.Models.CProfesseur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Professeurs");
                });

            modelBuilder.Entity("TeacherParadise.Models.CConge", b =>
                {
                    b.HasOne("TeacherParadise.Models.CProfesseur", "Professeur")
                        .WithMany("ListeConge")
                        .HasForeignKey("ProfesseurID");
                });

            modelBuilder.Entity("TeacherParadise.Models.CCoursCollectif", b =>
                {
                    b.HasOne("TeacherParadise.Models.CMatieres", "Matieres")
                        .WithMany()
                        .HasForeignKey("MatieresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeacherParadise.Models.CProfesseur", "Professeur")
                        .WithMany("CoursCollectifs")
                        .HasForeignKey("ProfesseurID");
                });

            modelBuilder.Entity("TeacherParadise.Models.CCoursRemediation", b =>
                {
                    b.HasOne("TeacherParadise.Models.CProfesseur", "Professeur")
                        .WithMany("CoursRemediations")
                        .HasForeignKey("ProfesseurID");
                });

            modelBuilder.Entity("TeacherParadise.Models.CMatieres", b =>
                {
                    b.HasOne("TeacherParadise.Models.CProfesseur", null)
                        .WithMany("Matieres")
                        .HasForeignKey("CProfesseurID");
                });
#pragma warning restore 612, 618
        }
    }
}
