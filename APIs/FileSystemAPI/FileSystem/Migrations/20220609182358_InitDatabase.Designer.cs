﻿// <auto-generated />
using System;
using FileSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileSystem.Migrations
{
    [DbContext(typeof(FilesContext))]
    [Migration("20220609182358_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FileSystem.Models.TutorImage", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("profileImage");

                    b.Property<byte[]>("Transcript")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("transcript");

                    b.HasKey("Id");

                    b.ToTable("TutorImages");
                });
#pragma warning restore 612, 618
        }
    }
}
