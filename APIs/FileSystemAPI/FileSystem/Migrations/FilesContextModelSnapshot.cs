﻿// <auto-generated />
using System;
using FileSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileSystem.Migrations
{
    [DbContext(typeof(FilesContext))]
    partial class FilesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FileSystem.Models.UserFiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<byte[]>("UserImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("UserImage");

                    b.Property<byte[]>("UserTranscript")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("UserTranscript");

                    b.HasKey("Id");

                    b.ToTable("UserFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
