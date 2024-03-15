﻿// <auto-generated />
using System;
using APIFun.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIFun.Migrations
{
    [DbContext(typeof(BowlerContext))]
    partial class BowlerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("APIFun.Data.Bowlers", b =>
                {
                    b.Property<int?>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BowlerZip")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("BowlerID");

                    b.ToTable("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
