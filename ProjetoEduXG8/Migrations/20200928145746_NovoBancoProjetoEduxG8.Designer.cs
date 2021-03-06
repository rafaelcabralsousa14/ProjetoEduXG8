﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEduXG8.Contexts;

namespace ProjetoEduXG8.Migrations
{
    [DbContext(typeof(DbEduxContext))]
    [Migration("20200928145746_NovoBancoProjetoEduxG8")]
    partial class NovoBancoProjetoEduxG8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoEduXG8.Domains.Curtida", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCurtida")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdUsuario");

                    b.ToTable("Curtidas");
                });

            modelBuilder.Entity("ProjetoEduXG8.Domains.Objetivo", b =>
                {
                    b.Property<Guid>("IdObjetivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdObjetivo");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("ProjetoEduXG8.Domains.Perfil", b =>
                {
                    b.Property<Guid>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permissao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfils");
                });
#pragma warning restore 612, 618
        }
    }
}
