﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiTiempo.Models;

namespace WebApiTiempo.Migrations
{
    [DbContext(typeof(TiempoContext))]
    partial class TiempoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiTiempo.Models.InformacionTiempo", b =>
                {
                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Datos_ultima_hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpxX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpxY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Humedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precipitacion_Acumulada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Velocidad_Viento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Municipio");

                    b.ToTable("TiempoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
