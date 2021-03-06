// <auto-generated />
using System;
using LogicSolutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogicSolutionBackenProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220601102232_RemoveCantVehiculosFlotaModel")]
    partial class RemoveCantVehiculosFlotaModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LogicSolutionBackenProject.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Lat")
                        .HasColumnType("int");

                    b.Property<int>("Long")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId")
                        .IsUnique();

                    b.ToTable("maps");
                });

            modelBuilder.Entity("LogicSolutions.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contactos");
                });

            modelBuilder.Entity("LogicSolutions.Models.Flota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreFlota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeCarga")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("flotas");
                });

            modelBuilder.Entity("LogicSolutions.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Carga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FlotaId")
                        .HasColumnType("int");

                    b.Property<int>("Itv")
                        .HasColumnType("int");

                    b.Property<double>("KmRecorridos")
                        .HasColumnType("float");

                    b.Property<int?>("MapId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlotaId");

                    b.ToTable("vehiculos");
                });

            modelBuilder.Entity("LogicSolutionBackenProject.Models.Map", b =>
                {
                    b.HasOne("LogicSolutions.Models.Vehiculo", "Vehiculo")
                        .WithOne("map")
                        .HasForeignKey("LogicSolutionBackenProject.Models.Map", "VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("LogicSolutions.Models.Vehiculo", b =>
                {
                    b.HasOne("LogicSolutions.Models.Flota", "flota")
                        .WithMany()
                        .HasForeignKey("FlotaId");

                    b.Navigation("flota");
                });

            modelBuilder.Entity("LogicSolutions.Models.Vehiculo", b =>
                {
                    b.Navigation("map");
                });
#pragma warning restore 612, 618
        }
    }
}
