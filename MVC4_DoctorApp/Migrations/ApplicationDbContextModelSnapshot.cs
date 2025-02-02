﻿// <auto-generated />
using System;
using MVC4_DoctorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC4_DoctorApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("MVC4_DoctorApp.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specailzation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MVC4_DoctorApp.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("MVC4_DoctorApp.Models.Slot", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bookingdetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId1")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("SlotTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SlotId");

                    b.HasIndex("DoctorId1");

                    b.HasIndex("PatientId1");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("MVC4_DoctorApp.Models.Slot", b =>
                {
                    b.HasOne("MVC4_DoctorApp.Models.Doctor", "DoctorId")
                        .WithMany()
                        .HasForeignKey("DoctorId1");

                    b.HasOne("MVC4_DoctorApp.Models.Patient", "PatientId")
                        .WithMany()
                        .HasForeignKey("PatientId1");

                    b.Navigation("DoctorId");

                    b.Navigation("PatientId");
                });
#pragma warning restore 612, 618
        }
    }
}
