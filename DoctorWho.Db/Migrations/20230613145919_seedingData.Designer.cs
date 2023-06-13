﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20230613145919_seedingData")]
    partial class seedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.Property<int>("CompanionsCompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("CompanionsCompanionId", "EpisodeId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("CompanionEpisode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Jane Austen"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Ernest Hemingway"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "J.K. Rowling"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Charles Dickens"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Agatha Christie"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Rose Tyler",
                            WhoPlayed = "Billie Piper"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Amy Pond",
                            WhoPlayed = "Karen Gillan"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Clara Oswald",
                            WhoPlayed = "Jenna Coleman"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Donna Noble",
                            WhoPlayed = "Catherine Tate"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Martha Jones",
                            WhoPlayed = "Freema Agyeman"
                        },
                        new
                        {
                            CompanionId = 6,
                            CompanionName = "Rory Williams",
                            WhoPlayed = "Arthur Darvill"
                        },
                        new
                        {
                            CompanionId = 7,
                            CompanionName = "River Song",
                            WhoPlayed = "Alex Kingston"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "William Hartnell",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1971, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "David Tennant",
                            DoctorNumber = 10,
                            FirstEpisodeDate = new DateTime(2005, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Matt Smith",
                            DoctorNumber = 11,
                            FirstEpisodeDate = new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1958, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Peter Capaldi",
                            DoctorNumber = 12,
                            FirstEpisodeDate = new DateTime(2014, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1982, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jodie Whittaker",
                            DoctorNumber = 13,
                            FirstEpisodeDate = new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("EnemyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            EnemyDescription = "Ruthless cyborg conquerors",
                            EnemyName = "Daleks"
                        },
                        new
                        {
                            EnemyId = 2,
                            EnemyDescription = "Cybernetic humanoids seeking perfection",
                            EnemyName = "Cybermen"
                        },
                        new
                        {
                            EnemyId = 3,
                            EnemyDescription = "The Doctor's Time Lord nemesis",
                            EnemyName = "The Master"
                        },
                        new
                        {
                            EnemyId = 4,
                            EnemyDescription = "Quantum-locked predatory beings",
                            EnemyName = "Weeping Angels"
                        },
                        new
                        {
                            EnemyId = 5,
                            EnemyDescription = "Memory-manipulating religious order",
                            EnemyName = "The Silence"
                        },
                        new
                        {
                            EnemyId = 6,
                            EnemyDescription = "Beings",
                            EnemyName = "Clockwork androids"
                        },
                        new
                        {
                            EnemyId = 7,
                            EnemyDescription = "A creature designed to extract information from the Doctor",
                            EnemyName = "The Veil"
                        },
                        new
                        {
                            EnemyId = 8,
                            EnemyDescription = "Specifically, Tzim-Sha, a warrior of the Stenza race",
                            EnemyName = "Stenza"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Historical Adventure",
                            SeriesNumber = 1,
                            Title = "The Daleks"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2006, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "Sci-Fi Adventure",
                            SeriesNumber = 2,
                            Title = "The Girl in the Fireplace"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2010, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 10,
                            EpisodeType = "Drama, Mystery",
                            SeriesNumber = 5,
                            Title = "Vincent and the Doctor"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2015, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 11,
                            EpisodeType = "Sci-Fi Adventure",
                            SeriesNumber = 9,
                            Title = "Heaven Sent"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Adventure, Drama",
                            SeriesNumber = 11,
                            Title = "The Woman Who Fell to Earth"
                        },
                        new
                        {
                            EpisodeId = 6,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 8,
                            EpisodeType = "Historical Adventure",
                            SeriesNumber = 1,
                            Title = "The Reign of Terror"
                        },
                        new
                        {
                            EpisodeId = 7,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 10,
                            EpisodeType = "Sci-Fi Adventure",
                            SeriesNumber = 3,
                            Title = "Blink"
                        },
                        new
                        {
                            EpisodeId = 8,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2012, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "Sci-Fi Adventure",
                            SeriesNumber = 7,
                            Title = "The Angels Take Manhattan"
                        },
                        new
                        {
                            EpisodeId = 9,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 11,
                            EpisodeType = "Sci-Fi Adventure",
                            SeriesNumber = 8,
                            Title = "Dark Water"
                        },
                        new
                        {
                            EpisodeId = 10,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 10,
                            EpisodeType = "Adventure, Drama",
                            SeriesNumber = 12,
                            Title = "The Timeless Children"
                        });
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.Property<int>("EnemiesEnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EnemiesEnemyId", "EpisodeId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EnemyEpisode");
                });

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", null)
                        .WithMany()
                        .HasForeignKey("CompanionsCompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", null)
                        .WithMany()
                        .HasForeignKey("EnemiesEnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
