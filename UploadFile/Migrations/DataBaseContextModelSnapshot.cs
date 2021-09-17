﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UploadFile.Models;

namespace UploadFile.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UploadFile.Entidades.Intercambio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataEmbarque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destinatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEmpresaEmbarcadora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Intercambio");
                });

            modelBuilder.Entity("UploadFile.Entidades.NotaFiscal", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Acondicionamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodicaoDeFrete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoRota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cubagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataDaEmissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataFinalEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataInicialEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInicialEnterga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICMS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("IntercambioId")
                        .HasColumnType("bigint");

                    b.Property<string>("MeioDeTransporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Natureza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeorDaNotaFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperacaoNotaFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeriodoDeEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantidadeDeVolumes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Romaneio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerieDaNotaFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeCarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeTransporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valordanota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntercambioId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("UploadFile.Entidades.NotaFiscalParticipante", b =>
                {
                    b.Property<string>("RazaoSocial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AreaFrete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNPJs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ceps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataFinalEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataInicialEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteBairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteCNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteCep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteCidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteCodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteInscricaoEstadual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteLogradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteRazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreteTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FretecodigoMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInicialEnterga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InscricaoEstadual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotaFiscalId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OperacaoNotaFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeriodoDeEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RazaoSocial");

                    b.HasIndex("NotaFiscalId");

                    b.ToTable("FiscalParticipantes");
                });

            modelBuilder.Entity("UploadFile.Models.Files", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("DataFiles")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DocumentId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("UploadFile.Entidades.NotaFiscal", b =>
                {
                    b.HasOne("UploadFile.Entidades.Intercambio", null)
                        .WithMany("NotasFiscais")
                        .HasForeignKey("IntercambioId");
                });

            modelBuilder.Entity("UploadFile.Entidades.NotaFiscalParticipante", b =>
                {
                    b.HasOne("UploadFile.Entidades.NotaFiscal", null)
                        .WithMany("Participantes")
                        .HasForeignKey("NotaFiscalId");
                });

            modelBuilder.Entity("UploadFile.Entidades.Intercambio", b =>
                {
                    b.Navigation("NotasFiscais");
                });

            modelBuilder.Entity("UploadFile.Entidades.NotaFiscal", b =>
                {
                    b.Navigation("Participantes");
                });
#pragma warning restore 612, 618
        }
    }
}
