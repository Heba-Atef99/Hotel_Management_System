﻿// <auto-generated />
using System;
using HospitalManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ain_Shams_Hospital.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20201213094828_new1")]
    partial class new1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Blood_Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blood_Units");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Facility_Reservation", b =>
                {
                    b.Property<string>("End_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hospital_Facility_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Staff_Id")
                        .HasColumnType("int");

                    b.Property<string>("Start_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Hospital_Facility_Id");

                    b.HasIndex("Patient_Id");

                    b.HasIndex("Staff_Id");

                    b.ToTable("Facility_Reservations");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Follow_Up", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Staff_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Patient_Id");

                    b.HasIndex("Staff_Id");

                    b.ToTable("Follow_Ups");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Follow_Up_History", b =>
                {
                    b.Property<string>("End_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Follow_Up_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Follow_Up_Type_Id")
                        .HasColumnType("int");

                    b.Property<string>("Start_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Follow_Up_Id");

                    b.HasIndex("Follow_Up_Type_Id");

                    b.ToTable("Follow_Ups_History");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Follow_Up_Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Follow_Ups_Types");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Hospital_Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("End_Working_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start_Working_Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospital_Facilities");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Health_Progress")
                        .HasColumnType("int");

                    b.Property<string>("Medical_Record")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegistrationId")
                        .HasColumnType("int");

                    b.Property<int?>("Registration_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("Registration_Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<int?>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Payed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Registration_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Specialization_Id")
                        .HasColumnType("int");

                    b.Property<string>("Starting_Day")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Registration_Id");

                    b.HasIndex("Specialization_Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Staff_Schedule", b =>
                {
                    b.Property<int?>("Specialization_Id")
                        .HasColumnType("int");

                    b.Property<string>("Working_Day")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Specialization_Id");

                    b.ToTable("Staff_Schedules");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Transfer_Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transfer_Hospitals");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Facility_Reservation", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Hospital_Facility", "Hospital_Facility_")
                        .WithMany()
                        .HasForeignKey("Hospital_Facility_Id");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Patient", "Patient_")
                        .WithMany()
                        .HasForeignKey("Patient_Id");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Staff", "Staff_")
                        .WithMany()
                        .HasForeignKey("Staff_Id");

                    b.Navigation("Hospital_Facility_");

                    b.Navigation("Patient_");

                    b.Navigation("Staff_");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Follow_Up", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Patient", "Patient_")
                        .WithMany()
                        .HasForeignKey("Patient_Id");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Staff", "Staff_")
                        .WithMany()
                        .HasForeignKey("Staff_Id");

                    b.Navigation("Patient_");

                    b.Navigation("Staff_");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Follow_Up_History", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Follow_Up", "Follow_Up_")
                        .WithMany()
                        .HasForeignKey("Follow_Up_Id");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Follow_Up_Type", "Follow_Up_Type_")
                        .WithMany()
                        .HasForeignKey("Follow_Up_Type_Id");

                    b.Navigation("Follow_Up_");

                    b.Navigation("Follow_Up_Type_");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Patient", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Registration", "Registration")
                        .WithMany()
                        .HasForeignKey("RegistrationId");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Transfer_Hospital", "Hospital_")
                        .WithMany()
                        .HasForeignKey("Registration_Id");

                    b.Navigation("Hospital_");

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Payment", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Patient", "Patient_")
                        .WithMany()
                        .HasForeignKey("Patient_Id");

                    b.Navigation("Patient_");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Staff", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Registration", "Registration_")
                        .WithMany()
                        .HasForeignKey("Registration_Id");

                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Specialization", "Specialization_")
                        .WithMany()
                        .HasForeignKey("Specialization_Id");

                    b.Navigation("Registration_");

                    b.Navigation("Specialization_");
                });

            modelBuilder.Entity("Ain_Shams_Hospital.Data.Entities.Staff_Schedule", b =>
                {
                    b.HasOne("Ain_Shams_Hospital.Data.Entities.Specialization", "Specialization_")
                        .WithMany()
                        .HasForeignKey("Specialization_Id");

                    b.Navigation("Specialization_");
                });
#pragma warning restore 612, 618
        }
    }
}
