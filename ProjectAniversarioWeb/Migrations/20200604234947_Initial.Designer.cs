﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAniversarioWeb.Data;

namespace ProjectAniversarioWeb.Migrations
{
    [DbContext(typeof(ProjectAniversarioWebContext))]
    [Migration("20200604234947_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectAniversarioWeb.Models.Aniversariante", b =>
                {
                    b.Property<string>("primeiroNome")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataAniversario");

                    b.Property<string>("segundoNome");

                    b.HasKey("primeiroNome");

                    b.ToTable("Aniversariante");
                });
#pragma warning restore 612, 618
        }
    }
}
