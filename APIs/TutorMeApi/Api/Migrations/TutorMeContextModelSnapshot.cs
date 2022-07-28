﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(TutorMeContext))]
    partial class TutorMeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(800)
                        .IsUnicode(false)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("Api.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("GroupLink")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("groupLink");

                    b.Property<string>("ModuleCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("moduleCode");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("moduleName");

                    b.Property<string>("Tutees")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("tutees");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("tutorId");

                    b.HasKey("Id");

                    b.ToTable("Group", (string)null);
                });

            modelBuilder.Entity("Api.Models.Module", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(800)
                        .IsUnicode(false)
                        .HasColumnType("varchar(800)")
                        .HasColumnName("code");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("faculty");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("institution");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("moduleName");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("year");

                    b.HasKey("Code")
                        .HasName("PK__Modules__357D4CF8AD050163");

                    b.ToTable("Module", (string)null);
                });

            modelBuilder.Entity("Api.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("dateCreated");

                    b.Property<string>("ModuleCode")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("moduleCode");

                    b.Property<string>("ReceiverId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("receiverId");

                    b.Property<string>("RequesterId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("requesterId");

                    b.HasKey("Id");

                    b.ToTable("Request", (string)null);
                });

            modelBuilder.Entity("Api.Models.Tutee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Bio")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("bio");

                    b.Property<string>("Connections")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("connections");

                    b.Property<string>("Course")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("course");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Faculty")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("faculty");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("GroupIds")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("groupIds");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("institution");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("Location")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("location");

                    b.Property<string>("Modules")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("modules");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("status")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("TutorsCode")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("tutorsCode");

                    b.Property<string>("Year")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("Tutee", (string)null);
                });

            modelBuilder.Entity("Api.Models.Tutor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Bio")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("bio");

                    b.Property<string>("Connections")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("connections");

                    b.Property<string>("Course")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("course");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Faculty")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("faculty");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("GroupIds")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("groupIds");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("institution");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("Location")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("location");

                    b.Property<string>("Modules")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("modules");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("rating")
                        .HasDefaultValueSql("('0,0')");

                    b.Property<string>("Requests")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("requests");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("status")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("TuteesCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("tuteesCode");

                    b.Property<string>("Year")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("Tutor", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
