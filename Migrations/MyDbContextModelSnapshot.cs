﻿// <auto-generated />
using System;
using ControlStock.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlStock.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControlStock.Data.MyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaswordChange")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Articulo", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArticulo"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)")
                        .HasDefaultValue("");

                    b.Property<int?>("StockMin")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdArticulo");

                    b.HasIndex(new[] { "IdMarca" }, "IX_Articulo_IdMarca");

                    b.ToTable("Articulo", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.DepositoArticuloLote", b =>
                {
                    b.Property<int>("DepositoArticuloLoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepositoArticuloLoteId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("LoteId")
                        .HasColumnType("int");

                    b.Property<int?>("ScopeId")
                        .HasColumnType("int");

                    b.HasKey("DepositoArticuloLoteId");

                    b.HasIndex(new[] { "ArticuloId" }, "IX_DepositoArticuloLotes_ArticuloId");

                    b.HasIndex(new[] { "LoteId" }, "IX_DepositoArticuloLotes_LoteId");

                    b.HasIndex(new[] { "ScopeId" }, "IX_DepositoArticuloLotes_ScopeId");

                    b.ToTable("DepositoArticuloLotes");
                });

            modelBuilder.Entity("ControlStock.Models.DetalleEgreso", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("EgresoId")
                        .HasColumnType("int");

                    b.Property<int?>("LoteId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex(new[] { "ArticuloId" }, "IX_DetalleEgreso_ArticuloId");

                    b.HasIndex(new[] { "EgresoId" }, "IX_DetalleEgreso_EgresoId");

                    b.HasIndex(new[] { "LoteId" }, "IX_DetalleEgreso_LoteId");

                    b.ToTable("DetalleEgresos");
                });

            modelBuilder.Entity("ControlStock.Models.DetalleIngreso", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("IngresoId")
                        .HasColumnType("int");

                    b.Property<int?>("LoteId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex(new[] { "ArticuloId" }, "IX_DetalleIngreso_ArticuloId");

                    b.HasIndex(new[] { "IngresoId" }, "IX_DetalleIngreso_IngresoId");

                    b.HasIndex(new[] { "LoteId" }, "IX_DetalleIngreso_LoteId");

                    b.ToTable("DetalleIngreso", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Egresos", b =>
                {
                    b.Property<int>("EgresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EgresoId"));

                    b.Property<int>("Destino")
                        .HasColumnType("int");

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEgreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValue("");

                    b.Property<int>("ScopeId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EgresoId");

                    b.HasIndex("Destino");

                    b.HasIndex("ScopeId");

                    b.HasIndex("SectionId");

                    b.HasIndex("UserId")
                        .HasDatabaseName("IX_Egresos_UserId");

                    b.ToTable("Egresos");
                });

            modelBuilder.Entity("ControlStock.Models.Ingresos", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoId"));

                    b.Property<string>("Comprobante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasDefaultValue("");

                    b.Property<int?>("ProveedorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("ScopeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("IngresoId");

                    b.HasIndex("ScopeId");

                    b.HasIndex(new[] { "ProveedorId" }, "IX_Ingresos_ProveedorId");

                    b.ToTable("Ingresos");
                });

            modelBuilder.Entity("ControlStock.Models.Lote", b =>
                {
                    b.Property<int>("LoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoteId"));

                    b.Property<DateTime?>("FechaElaboracion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroLote")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("LoteId");

                    b.ToTable("Lote", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"));

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<int>("IdRubro")
                        .HasColumnType("int");

                    b.Property<string>("MarcaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMarca");

                    b.HasIndex("IdRubro");

                    b.HasIndex("UserId");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Proveedor", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProveedorId"));

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProveedorAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProveedorMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProveedorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProveedorPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Rubro", b =>
                {
                    b.Property<int>("IdRubro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRubro"));

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdRubro");

                    b.HasIndex("SectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Rubro", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Scope", b =>
                {
                    b.Property<int>("ScopeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScopeId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EliminadoLogico")
                        .HasColumnType("bit");

                    b.Property<string>("ScopeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("ScopeId");

                    b.ToTable("Scopes");
                });

            modelBuilder.Entity("ControlStock.Models.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionId"));

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("ControlStock.Models.SectionProveedor", b =>
                {
                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("ProveedorId", "SectionId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionProveedores");
                });

            modelBuilder.Entity("ControlStock.Models.UserPermission", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("ScopeId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SectionId", "ScopeId");

                    b.HasIndex(new[] { "ScopeId" }, "IX_UserPermissions_ScopeId");

                    b.HasIndex(new[] { "SectionId" }, "IX_UserPermissions_SectionId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ControlStock.Models.Articulo", b =>
                {
                    b.HasOne("ControlStock.Models.Marca", "Marca")
                        .WithMany("Articulos")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("ControlStock.Models.DepositoArticuloLote", b =>
                {
                    b.HasOne("ControlStock.Models.Articulo", "Articulo")
                        .WithMany("DepositoArticuloLotes")
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Lote", "Lote")
                        .WithMany("DepositoArticuloLotes")
                        .HasForeignKey("LoteId");

                    b.HasOne("ControlStock.Models.Scope", "Scope")
                        .WithMany("DepositoArticuloLotes")
                        .HasForeignKey("ScopeId")
                        .HasConstraintName("FK_DepositoArticuloLotes_Scopes");

                    b.Navigation("Articulo");

                    b.Navigation("Lote");

                    b.Navigation("Scope");
                });

            modelBuilder.Entity("ControlStock.Models.DetalleEgreso", b =>
                {
                    b.HasOne("ControlStock.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Egresos", "Egreso")
                        .WithMany("DetalleEgresos")
                        .HasForeignKey("EgresoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ControlStock.Models.Lote", "Lote")
                        .WithMany()
                        .HasForeignKey("LoteId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Articulo");

                    b.Navigation("Egreso");

                    b.Navigation("Lote");
                });

            modelBuilder.Entity("ControlStock.Models.DetalleIngreso", b =>
                {
                    b.HasOne("ControlStock.Models.Articulo", "Articulo")
                        .WithMany("DetalleIngresos")
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Ingresos", "Ingresos")
                        .WithMany("DetalleIngresos")
                        .HasForeignKey("IngresoId");

                    b.HasOne("ControlStock.Models.Lote", "Lote")
                        .WithMany("DetalleIngresos")
                        .HasForeignKey("LoteId");

                    b.Navigation("Articulo");

                    b.Navigation("Ingresos");

                    b.Navigation("Lote");
                });

            modelBuilder.Entity("ControlStock.Models.Egresos", b =>
                {
                    b.HasOne("ControlStock.Models.Scope", "DestinoScope")
                        .WithMany()
                        .HasForeignKey("Destino")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Scope", "Scope")
                        .WithMany("Egresos")
                        .HasForeignKey("ScopeId")
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Section", "Section")
                        .WithMany("Egresos")
                        .HasForeignKey("SectionId")
                        .IsRequired();

                    b.Navigation("DestinoScope");

                    b.Navigation("Scope");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("ControlStock.Models.Ingresos", b =>
                {
                    b.HasOne("ControlStock.Models.Proveedor", "Proveedor")
                        .WithMany("Ingresos")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Scope", "Scope")
                        .WithMany("Ingresos")
                        .HasForeignKey("ScopeId")
                        .IsRequired()
                        .HasConstraintName("FK_Ingreso_Scopes");

                    b.Navigation("Proveedor");

                    b.Navigation("Scope");
                });

            modelBuilder.Entity("ControlStock.Models.Marca", b =>
                {
                    b.HasOne("ControlStock.Models.Rubro", "Rubro")
                        .WithMany("Marcas")
                        .HasForeignKey("IdRubro")
                        .IsRequired()
                        .HasConstraintName("FK_Marca_Rubro");

                    b.HasOne("ControlStock.Data.MyUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rubro");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ControlStock.Models.Rubro", b =>
                {
                    b.HasOne("ControlStock.Models.Section", "Section")
                        .WithMany("Rubros")
                        .HasForeignKey("SectionId")
                        .IsRequired()
                        .HasConstraintName("FK_Rubro_Sections");

                    b.HasOne("ControlStock.Data.MyUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ControlStock.Models.SectionProveedor", b =>
                {
                    b.HasOne("ControlStock.Models.Proveedor", "Proveedor")
                        .WithMany("SectionProveedores")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Section", "Section")
                        .WithMany("SectionProveedores")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("ControlStock.Models.UserPermission", b =>
                {
                    b.HasOne("ControlStock.Models.Scope", "Scope")
                        .WithMany("UserPermissions")
                        .HasForeignKey("ScopeId")
                        .IsRequired();

                    b.HasOne("ControlStock.Models.Section", "Section")
                        .WithMany("UserPermissions")
                        .HasForeignKey("SectionId")
                        .IsRequired()
                        .HasConstraintName("FK_UserPermissions_Sections");

                    b.HasOne("ControlStock.Data.MyUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scope");

                    b.Navigation("Section");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ControlStock.Data.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ControlStock.Data.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStock.Data.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ControlStock.Data.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlStock.Models.Articulo", b =>
                {
                    b.Navigation("DepositoArticuloLotes");

                    b.Navigation("DetalleIngresos");
                });

            modelBuilder.Entity("ControlStock.Models.Egresos", b =>
                {
                    b.Navigation("DetalleEgresos");
                });

            modelBuilder.Entity("ControlStock.Models.Ingresos", b =>
                {
                    b.Navigation("DetalleIngresos");
                });

            modelBuilder.Entity("ControlStock.Models.Lote", b =>
                {
                    b.Navigation("DepositoArticuloLotes");

                    b.Navigation("DetalleIngresos");
                });

            modelBuilder.Entity("ControlStock.Models.Marca", b =>
                {
                    b.Navigation("Articulos");
                });

            modelBuilder.Entity("ControlStock.Models.Proveedor", b =>
                {
                    b.Navigation("Ingresos");

                    b.Navigation("SectionProveedores");
                });

            modelBuilder.Entity("ControlStock.Models.Rubro", b =>
                {
                    b.Navigation("Marcas");
                });

            modelBuilder.Entity("ControlStock.Models.Scope", b =>
                {
                    b.Navigation("DepositoArticuloLotes");

                    b.Navigation("Egresos");

                    b.Navigation("Ingresos");

                    b.Navigation("UserPermissions");
                });

            modelBuilder.Entity("ControlStock.Models.Section", b =>
                {
                    b.Navigation("Egresos");

                    b.Navigation("Rubros");

                    b.Navigation("SectionProveedores");

                    b.Navigation("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
