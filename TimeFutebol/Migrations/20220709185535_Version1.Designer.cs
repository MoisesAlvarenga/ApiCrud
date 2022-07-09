﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeFutebol.Data;

namespace TimeFutebol.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220709185535_Version1")]
    partial class Version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("TimeFutebol.Models.JogadorModel", b =>
                {
                    b.Property<int>("IdJogador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Altura")
                        .HasColumnType("REAL");

                    b.Property<int>("Camisa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<float>("Peso")
                        .HasColumnType("REAL");

                    b.Property<string>("Posicao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TimeFK")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdJogador");

                    b.HasIndex("TimeFK");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("TimeFutebol.Models.TimeModel", b =>
                {
                    b.Property<int>("IdTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .HasColumnType("TEXT");

                    b.HasKey("IdTime");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("TimeFutebol.Models.JogadorModel", b =>
                {
                    b.HasOne("TimeFutebol.Models.TimeModel", "Time")
                        .WithMany("Jogador")
                        .HasForeignKey("TimeFK");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("TimeFutebol.Models.TimeModel", b =>
                {
                    b.Navigation("Jogador");
                });
#pragma warning restore 612, 618
        }
    }
}
