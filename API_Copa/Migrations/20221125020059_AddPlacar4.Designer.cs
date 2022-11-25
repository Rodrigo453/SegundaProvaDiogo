﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace API_Copa.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221125020059_AddPlacar4")]
    partial class AddPlacar4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SelecaoAId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SelecaoBId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Selecao_Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Selecao");

                    b.HasKey("Id");

                    b.HasIndex("SelecaoAId");

                    b.HasIndex("SelecaoBId");

                    b.HasIndex("Selecao_Id");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("API_Copa.Models.Selecao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Selecoes");
                });

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.HasOne("API_Copa.Models.Selecao", "SelecaoA")
                        .WithMany()
                        .HasForeignKey("SelecaoAId");

                    b.HasOne("API_Copa.Models.Selecao", "SelecaoB")
                        .WithMany()
                        .HasForeignKey("SelecaoBId");

                    b.HasOne("API_Copa.Models.Selecao", "Selecao")
                        .WithMany()
                        .HasForeignKey("Selecao_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Selecao");

                    b.Navigation("SelecaoA");

                    b.Navigation("SelecaoB");
                });
#pragma warning restore 612, 618
        }
    }
}
