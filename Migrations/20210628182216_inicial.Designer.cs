// <auto-generated />
using System;
using CartaOnline.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartaOnline_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210628182216_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CartaOnline.Models.Comanda", b =>
                {
                    b.Property<int>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaEntregaId")
                        .HasColumnType("int");

                    b.Property<int>("PrecioTotal")
                        .HasColumnType("int");

                    b.HasKey("ComandaId");

                    b.HasIndex("FormaEntregaId");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("CartaOnline.Models.ComandaMercaderia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("MercaderiaId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ComandaId");

                    b.HasIndex("MercaderiaId");

                    b.ToTable("ComandaMercaderias");
                });

            modelBuilder.Entity("CartaOnline.Models.FormaEntrega", b =>
                {
                    b.Property<int>("FormaEntregaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FormaEntregaId");

                    b.ToTable("FormasEntregas");

                    b.HasData(
                        new
                        {
                            FormaEntregaId = 1,
                            Descripcion = "Salon"
                        },
                        new
                        {
                            FormaEntregaId = 2,
                            Descripcion = "Delivery"
                        },
                        new
                        {
                            FormaEntregaId = 3,
                            Descripcion = "Pedidos Ya"
                        });
                });

            modelBuilder.Entity("CartaOnline.Models.Mercaderia", b =>
                {
                    b.Property<int>("MercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Preparacion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TipoMercaderiaId")
                        .HasColumnType("int");

                    b.HasKey("MercaderiaId");

                    b.HasIndex("TipoMercaderiaId");

                    b.ToTable("Mercaderias");

                    b.HasData(
                        new
                        {
                            MercaderiaId = 1,
                            Imagen = "image/milanesa.jpg",
                            Ingredientes = "Carne vacuna y pan",
                            Nombre = "Milanesa de Carne",
                            Precio = 350,
                            Preparacion = "frita",
                            TipoMercaderiaId = 6
                        },
                        new
                        {
                            MercaderiaId = 2,
                            Imagen = "image/coca.jpg",
                            Ingredientes = "no se sabe",
                            Nombre = "Coca Cola",
                            Precio = 100,
                            Preparacion = "fria",
                            TipoMercaderiaId = 8
                        },
                        new
                        {
                            MercaderiaId = 3,
                            Imagen = "image/helado.jpg",
                            Ingredientes = "leche",
                            Nombre = "Helado de Chocolate",
                            Precio = 150,
                            Preparacion = "fria",
                            TipoMercaderiaId = 10
                        },
                        new
                        {
                            MercaderiaId = 4,
                            Imagen = "image/milanesa.jpg",
                            Ingredientes = "Carne pollo y pan",
                            Nombre = "Milanesa de Pollo",
                            Precio = 350,
                            Preparacion = "frita",
                            TipoMercaderiaId = 6
                        },
                        new
                        {
                            MercaderiaId = 5,
                            Imagen = "image/pasta.jpg",
                            Ingredientes = "harina y sal",
                            Nombre = "Tallarines",
                            Precio = 300,
                            Preparacion = "hervida",
                            TipoMercaderiaId = 3
                        },
                        new
                        {
                            MercaderiaId = 6,
                            Imagen = "image/milanesa.jpg",
                            Ingredientes = "Carne vacuna al plato",
                            Nombre = "Milanesa con fritas",
                            Precio = 350,
                            Preparacion = "frita",
                            TipoMercaderiaId = 2
                        },
                        new
                        {
                            MercaderiaId = 7,
                            Imagen = "image/milanesa.jpg",
                            Ingredientes = "Carne vacuna y pan",
                            Nombre = "Milanesa de pollo con fritas",
                            Precio = 350,
                            Preparacion = "frita",
                            TipoMercaderiaId = 2
                        });
                });

            modelBuilder.Entity("CartaOnline.Models.TipoMercaderia", b =>
                {
                    b.Property<int>("TipoMercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoMercaderiaId");

                    b.ToTable("TipoMercaderia");

                    b.HasData(
                        new
                        {
                            TipoMercaderiaId = 1,
                            Descripcion = "Entrada"
                        },
                        new
                        {
                            TipoMercaderiaId = 2,
                            Descripcion = "Minutas"
                        },
                        new
                        {
                            TipoMercaderiaId = 3,
                            Descripcion = "Pastas"
                        },
                        new
                        {
                            TipoMercaderiaId = 4,
                            Descripcion = "Parrilla"
                        },
                        new
                        {
                            TipoMercaderiaId = 5,
                            Descripcion = "Pizzas"
                        },
                        new
                        {
                            TipoMercaderiaId = 6,
                            Descripcion = "Sandwich"
                        },
                        new
                        {
                            TipoMercaderiaId = 7,
                            Descripcion = "Ensaladas"
                        },
                        new
                        {
                            TipoMercaderiaId = 8,
                            Descripcion = "Bebidas"
                        },
                        new
                        {
                            TipoMercaderiaId = 9,
                            Descripcion = "Cerveza Artesanal"
                        },
                        new
                        {
                            TipoMercaderiaId = 10,
                            Descripcion = "Postres"
                        });
                });

            modelBuilder.Entity("CartaOnline.Models.Comanda", b =>
                {
                    b.HasOne("CartaOnline.Models.FormaEntrega", "FormaEntrega")
                        .WithMany("Comanda")
                        .HasForeignKey("FormaEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormaEntrega");
                });

            modelBuilder.Entity("CartaOnline.Models.ComandaMercaderia", b =>
                {
                    b.HasOne("CartaOnline.Models.Comanda", "Comanda")
                        .WithMany("ComandaMercaderia")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CartaOnline.Models.Mercaderia", "Mercaderia")
                        .WithMany("ComandaMercaderia")
                        .HasForeignKey("MercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Mercaderia");
                });

            modelBuilder.Entity("CartaOnline.Models.Mercaderia", b =>
                {
                    b.HasOne("CartaOnline.Models.TipoMercaderia", "TipoMercaderia")
                        .WithMany("Mercederias")
                        .HasForeignKey("TipoMercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMercaderia");
                });

            modelBuilder.Entity("CartaOnline.Models.Comanda", b =>
                {
                    b.Navigation("ComandaMercaderia");
                });

            modelBuilder.Entity("CartaOnline.Models.FormaEntrega", b =>
                {
                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("CartaOnline.Models.Mercaderia", b =>
                {
                    b.Navigation("ComandaMercaderia");
                });

            modelBuilder.Entity("CartaOnline.Models.TipoMercaderia", b =>
                {
                    b.Navigation("Mercederias");
                });
#pragma warning restore 612, 618
        }
    }
}
