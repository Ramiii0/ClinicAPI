﻿// <auto-generated />
using System;
using ClinicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinicAPI.Models.InvestigationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CRP")
                        .HasColumnType("int");

                    b.Property<int>("Creatinine")
                        .HasColumnType("int");

                    b.Property<int>("D_DIMER")
                        .HasColumnType("int");

                    b.Property<int>("ESR")
                        .HasColumnType("int");

                    b.Property<int>("FBS")
                        .HasColumnType("int");

                    b.Property<int>("FERRITIN")
                        .HasColumnType("int");

                    b.Property<int>("GUERBC")
                        .HasColumnType("int");

                    b.Property<int>("GUE_PUS")
                        .HasColumnType("int");

                    b.Property<int>("HB")
                        .HasColumnType("int");

                    b.Property<int>("HbA1c")
                        .HasColumnType("int");

                    b.Property<int>("PLATELETS")
                        .HasColumnType("int");

                    b.Property<int>("PSA")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("RBS")
                        .HasColumnType("int");

                    b.Property<int>("UREA")
                        .HasColumnType("int");

                    b.Property<int>("Uric_Acid")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<int>("WBC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("VisitId");

                    b.ToTable("Investigations");
                });

            modelBuilder.Entity("ClinicAPI.Models.PatientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surgical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            FirstName = "Mohammed",
                            Gender = "Male",
                            Height = 180,
                            LastName = "Raid",
                            Medical = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer in elementum massa. Aliquam  r",
                            Phone = 123,
                            Residence = "Baghdad",
                            Social = "wfvbeuibwjebdjiwvbwjklvf",
                            Surgical = "Lorem ipsum   , consectetur adipiscing elit. Integer in elementum massa. Aliquam elementum risus vitae   . Sed eu  tellus, eget lacinia",
                            Weight = 70
                        });
                });

            modelBuilder.Entity("ClinicAPI.Models.RadiologyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("VisitId");

                    b.ToTable("Radiology");
                });

            modelBuilder.Entity("ClinicAPI.Models.TreatmentsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Root")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("VisitId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("ClinicAPI.Models.VisitModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Examination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HPI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Visits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CC = "C.C details...",
                            Examination = "exam details",
                            HPI = "HPI details",
                            PR = "PR details",
                            PatientId = 1,
                            Title = "Visit 1",
                            VisitDate = new DateTime(2024, 8, 3, 0, 44, 49, 775, DateTimeKind.Local).AddTicks(4856)
                        });
                });

            modelBuilder.Entity("ClinicAPI.Models.InvestigationModel", b =>
                {
                    b.HasOne("ClinicAPI.Models.PatientModel", "Patient")
                        .WithMany("Investigations")
                        .HasForeignKey("PatientId")
                        .IsRequired();

                    b.HasOne("ClinicAPI.Models.VisitModel", "Visit")
                        .WithMany("Investigation")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("ClinicAPI.Models.RadiologyModel", b =>
                {
                    b.HasOne("ClinicAPI.Models.PatientModel", "Patient")
                        .WithMany("Radiologies")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicAPI.Models.VisitModel", "Visit")
                        .WithMany("Radiologies")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("ClinicAPI.Models.TreatmentsModel", b =>
                {
                    b.HasOne("ClinicAPI.Models.PatientModel", "Patient")
                        .WithMany("Treatments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicAPI.Models.VisitModel", "Visit")
                        .WithMany("Treatments")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("ClinicAPI.Models.VisitModel", b =>
                {
                    b.HasOne("ClinicAPI.Models.PatientModel", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicAPI.Models.PatientModel", b =>
                {
                    b.Navigation("Investigations");

                    b.Navigation("Radiologies");

                    b.Navigation("Treatments");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("ClinicAPI.Models.VisitModel", b =>
                {
                    b.Navigation("Investigation");

                    b.Navigation("Radiologies");

                    b.Navigation("Treatments");
                });
#pragma warning restore 612, 618
        }
    }
}
