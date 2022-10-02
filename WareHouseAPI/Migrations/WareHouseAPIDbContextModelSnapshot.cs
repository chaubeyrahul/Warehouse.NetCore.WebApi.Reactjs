﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WareHouseAPI.Data;

#nullable disable

namespace WareHouseAPI.Migrations
{
    [DbContext(typeof(WareHouseAPIDbContext))]
    partial class WareHouseAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("WareHouseAPI.Models.tblInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("inventoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("wareHouseID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("tblInventory");
                });

            modelBuilder.Entity("WareHouseAPI.Models.tblWarehouses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("wareHouseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblWarehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
