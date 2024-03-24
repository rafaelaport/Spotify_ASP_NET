﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotify.Repository;

#nullable disable

namespace Spotify.Repository.Migrations
{
    [DbContext(typeof(SpotifyContext))]
    [Migration("20240312203012_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicaPlaylist", b =>
                {
                    b.Property<Guid>("MusicasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaylistsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MusicasId", "PlaylistsId");

                    b.HasIndex("PlaylistsId");

                    b.ToTable("MusicaPlaylist");
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Assinatura", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DtAtivacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlanoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Assinatura", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Publica")
                        .HasColumnType("bit");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Playlist", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Notificacao.Notificacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtNotificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TipoNotificacao")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("UsuarioDestinoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioRemetenteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioDestinoId");

                    b.HasIndex("UsuarioRemetenteId");

                    b.ToTable("Notificacao", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BandaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BandaId");

                    b.ToTable("Album", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Banda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Backdrop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Banda", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Musica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Musica", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Plano", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Plano", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Transacao.Agreggates.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cartao", (string)null);
                });

            modelBuilder.Entity("Spotify.Domain.Transacao.Agreggates.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DtTransacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId");

                    b.ToTable("Transacao", (string)null);
                });

            modelBuilder.Entity("MusicaPlaylist", b =>
                {
                    b.HasOne("Spotify.Domain.Streaming.Agreggates.Musica", null)
                        .WithMany()
                        .HasForeignKey("MusicasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Domain.Conta.Agreggates.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Assinatura", b =>
                {
                    b.HasOne("Spotify.Domain.Streaming.Agreggates.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Domain.Conta.Agreggates.Usuario", null)
                        .WithMany("Assinaturas")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Playlist", b =>
                {
                    b.HasOne("Spotify.Domain.Conta.Agreggates.Usuario", "Usuario")
                        .WithMany("Playlists")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Spotify.Domain.Notificacao.Notificacao", b =>
                {
                    b.HasOne("Spotify.Domain.Conta.Agreggates.Usuario", "UsuarioDestino")
                        .WithMany("Notificacoes")
                        .HasForeignKey("UsuarioDestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Domain.Conta.Agreggates.Usuario", "UsuarioRemetente")
                        .WithMany()
                        .HasForeignKey("UsuarioRemetenteId");

                    b.Navigation("UsuarioDestino");

                    b.Navigation("UsuarioRemetente");
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Album", b =>
                {
                    b.HasOne("Spotify.Domain.Streaming.Agreggates.Banda", null)
                        .WithMany("Albums")
                        .HasForeignKey("BandaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Musica", b =>
                {
                    b.HasOne("Spotify.Domain.Streaming.Agreggates.Album", null)
                        .WithMany("Musica")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Spotify.Domain.Streaming.ValueObject.Duracao", "Duracao", b1 =>
                        {
                            b1.Property<Guid>("MusicaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Valor")
                                .HasMaxLength(50)
                                .HasColumnType("int");

                            b1.HasKey("MusicaId");

                            b1.ToTable("Musica");

                            b1.WithOwner()
                                .HasForeignKey("MusicaId");
                        });

                    b.Navigation("Duracao")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Plano", b =>
                {
                    b.OwnsOne("Spotify.Domain.Core.ValueObject.Monetario", "Valor", b1 =>
                        {
                            b1.Property<Guid>("PlanoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("PlanoId");

                            b1.ToTable("Plano");

                            b1.WithOwner()
                                .HasForeignKey("PlanoId");
                        });

                    b.Navigation("Valor")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Domain.Transacao.Agreggates.Cartao", b =>
                {
                    b.HasOne("Spotify.Domain.Conta.Agreggates.Usuario", null)
                        .WithMany("Cartoes")
                        .HasForeignKey("UsuarioId");

                    b.OwnsOne("Spotify.Domain.Core.ValueObject.Monetario", "Limite", b1 =>
                        {
                            b1.Property<Guid>("CartaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Limite");

                            b1.HasKey("CartaoId");

                            b1.ToTable("Cartao");

                            b1.WithOwner()
                                .HasForeignKey("CartaoId");
                        });

                    b.Navigation("Limite")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Domain.Transacao.Agreggates.Transacao", b =>
                {
                    b.HasOne("Spotify.Domain.Transacao.Agreggates.Cartao", null)
                        .WithMany("Transacoes")
                        .HasForeignKey("CartaoId");

                    b.OwnsOne("Spotify.Domain.Core.ValueObject.Monetario", "Valor", b1 =>
                        {
                            b1.Property<Guid>("TransacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("ValorTransacao");

                            b1.HasKey("TransacaoId");

                            b1.ToTable("Transacao");

                            b1.WithOwner()
                                .HasForeignKey("TransacaoId");
                        });

                    b.OwnsOne("Spotify.Domain.Transacao.ValueObject.Merchant", "Merchant", b1 =>
                        {
                            b1.Property<Guid>("TransacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Nome")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MerchantNome");

                            b1.HasKey("TransacaoId");

                            b1.ToTable("Transacao");

                            b1.WithOwner()
                                .HasForeignKey("TransacaoId");
                        });

                    b.Navigation("Merchant")
                        .IsRequired();

                    b.Navigation("Valor")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Domain.Conta.Agreggates.Usuario", b =>
                {
                    b.Navigation("Assinaturas");

                    b.Navigation("Cartoes");

                    b.Navigation("Notificacoes");

                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Album", b =>
                {
                    b.Navigation("Musica");
                });

            modelBuilder.Entity("Spotify.Domain.Streaming.Agreggates.Banda", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify.Domain.Transacao.Agreggates.Cartao", b =>
                {
                    b.Navigation("Transacoes");
                });
#pragma warning restore 612, 618
        }
    }
}