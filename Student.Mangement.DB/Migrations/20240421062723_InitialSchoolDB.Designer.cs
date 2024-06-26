﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student.Mangement.DB;

#nullable disable

namespace Student.Mangement.DB.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20240421062723_InitialSchoolDB")]
    partial class InitialSchoolDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student.Mangement.Entity.Role.RoleEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("RoleEntity");
                });

            modelBuilder.Entity("Student.Mangement.Entity.Student_Entity.StudentDetailsEntity", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifiedDate");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("StudentCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("RoleId");

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Student.Mangement.Entity.User.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifiedDate");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Student.Mangement.Entity.Student_Entity.StudentDetailsEntity", b =>
                {
                    b.HasOne("Student.Mangement.Entity.Role.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
