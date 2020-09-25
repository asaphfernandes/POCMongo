﻿// <auto-generated />
using System;
using Demo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Demo.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    partial class PostgreSqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Demo.Models.PostgreSql.TipoPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AspNetUserInsertId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Contabiliza")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<bool>("EmiteNF")
                        .HasColumnType("boolean");

                    b.Property<short>("EntradaSaida")
                        .HasColumnType("smallint");

                    b.Property<bool>("Estoque")
                        .HasColumnType("boolean");

                    b.Property<bool>("Financeiro")
                        .HasColumnType("boolean");

                    b.Property<short>("Grupo")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Inserted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Logistica")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<bool>("PDV")
                        .HasColumnType("boolean");

                    b.Property<bool>("PedidoSaida")
                        .HasColumnType("boolean");

                    b.Property<bool>("PortalAdm")
                        .HasColumnType("boolean");

                    b.Property<bool>("PortalFornecedor")
                        .HasColumnType("boolean");

                    b.Property<bool>("PortalLog")
                        .HasColumnType("boolean");

                    b.Property<bool>("PortalLoja")
                        .HasColumnType("boolean");

                    b.Property<bool>("Precifica")
                        .HasColumnType("boolean");

                    b.Property<short>("RevendaNaoRevenda")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("TipoPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
