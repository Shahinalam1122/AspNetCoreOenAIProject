﻿// <auto-generated />
using System;
using AspNetCoreWebApi.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240305031541_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreWebApi.Models.TextGenerate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Word")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("TextGenerates");
                });
#pragma warning restore 612, 618
        }
    }
}
