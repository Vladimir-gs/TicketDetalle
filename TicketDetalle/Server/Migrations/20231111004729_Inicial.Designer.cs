﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketDetalle.Server.DAL;

#nullable disable

namespace TicketDetalle.Server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231111004729_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("TicketDetalle.Shared.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("SolicitadoPor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketDetalle.Shared.TicketsDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emisor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mensaje")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketsDetalle");
                });

            modelBuilder.Entity("TicketDetalle.Shared.TicketsDetalle", b =>
                {
                    b.HasOne("TicketDetalle.Shared.Tickets", null)
                        .WithMany("TicketsDetalle")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TicketDetalle.Shared.Tickets", b =>
                {
                    b.Navigation("TicketsDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
