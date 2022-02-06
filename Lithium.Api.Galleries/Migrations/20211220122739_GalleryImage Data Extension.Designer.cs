﻿// <auto-generated />
using System;
using Lithium.Api.Galleries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lithium.Api.Galleries.Migrations
{
    [DbContext(typeof(GalleryContext))]
    [Migration("20211220122739_GalleryImage Data Extension")]
    partial class GalleryImageDataExtension
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Lithium.Api.Galleries.Gallery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("Lithium.Api.Galleries.GalleryImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Desription")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GalleryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GalleryId");

                    b.ToTable("GalleryImage");
                });

            modelBuilder.Entity("Lithium.Api.Galleries.GalleryImage", b =>
                {
                    b.HasOne("Lithium.Api.Galleries.Gallery", null)
                        .WithMany("Images")
                        .HasForeignKey("GalleryId");

                    b.OwnsOne("Lithium.Api.Galleries.ImageResolution", "Resolution", b1 =>
                        {
                            b1.Property<Guid>("GalleryImageId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Height")
                                .HasColumnType("INTEGER")
                                .HasColumnName("Height");

                            b1.Property<int>("Width")
                                .HasColumnType("INTEGER")
                                .HasColumnName("Width");

                            b1.HasKey("GalleryImageId");

                            b1.ToTable("GalleryImage");

                            b1.WithOwner()
                                .HasForeignKey("GalleryImageId");
                        });

                    b.Navigation("Resolution");
                });

            modelBuilder.Entity("Lithium.Api.Galleries.Gallery", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
