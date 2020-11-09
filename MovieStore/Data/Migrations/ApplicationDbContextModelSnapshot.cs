﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieStore.Data;

namespace MovieStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MovieStore.Data.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            FirstName = "Morgan",
                            LastName = "Freeman"
                        },
                        new
                        {
                            ActorId = 2,
                            FirstName = "Tim",
                            LastName = "Robbins"
                        },
                        new
                        {
                            ActorId = 3,
                            FirstName = "Bob",
                            LastName = "Gunton"
                        },
                        new
                        {
                            ActorId = 4,
                            FirstName = "Kevin",
                            LastName = "Spacey"
                        },
                        new
                        {
                            ActorId = 5,
                            FirstName = "Brad",
                            LastName = "Pitt"
                        },
                        new
                        {
                            ActorId = 6,
                            FirstName = "Jodie",
                            LastName = "Foster"
                        },
                        new
                        {
                            ActorId = 7,
                            FirstName = "Anthony",
                            LastName = "Hopkins"
                        },
                        new
                        {
                            ActorId = 8,
                            FirstName = "Marlon",
                            LastName = "Brando"
                        },
                        new
                        {
                            ActorId = 9,
                            FirstName = "Al",
                            LastName = "Pacino"
                        },
                        new
                        {
                            ActorId = 10,
                            FirstName = "Christopher",
                            LastName = "Waltz"
                        },
                        new
                        {
                            ActorId = 11,
                            FirstName = "Ivana",
                            LastName = "Baquero"
                        },
                        new
                        {
                            ActorId = 12,
                            FirstName = "Sergi",
                            LastName = "Lopez"
                        },
                        new
                        {
                            ActorId = 13,
                            FirstName = "Rumi",
                            LastName = "Hiiragi"
                        },
                        new
                        {
                            ActorId = 14,
                            FirstName = "Miyu",
                            LastName = "Irino"
                        },
                        new
                        {
                            ActorId = 15,
                            FirstName = "Russel",
                            LastName = "Crowe"
                        },
                        new
                        {
                            ActorId = 16,
                            FirstName = "Joaquin",
                            LastName = "Phoenix"
                        },
                        new
                        {
                            ActorId = 17,
                            FirstName = "Jamie",
                            LastName = "Foxx"
                        },
                        new
                        {
                            ActorId = 18,
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            ActorId = 19,
                            FirstName = "Joseph",
                            LastName = "Gordon-Levitt"
                        });
                });

            modelBuilder.Entity("MovieStore.Data.Models.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 7,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 9,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 10,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 11,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 12,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 14,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 13,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 15,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 16,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 18,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 17,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 10,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 18,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 19,
                            MovieId = 10
                        });
                });

            modelBuilder.Entity("MovieStore.Data.Models.CheckedOutMovies", b =>
                {
                    b.Property<int>("CheckedOutMoviesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CheckedOutMoviesId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("CheckedOutMovies");
                });

            modelBuilder.Entity("MovieStore.Data.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("DirectorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            DirectorId = 1,
                            FirstName = "Frank",
                            LastName = "Darabont"
                        },
                        new
                        {
                            DirectorId = 2,
                            FirstName = "David",
                            LastName = "Fincher"
                        },
                        new
                        {
                            DirectorId = 3,
                            FirstName = "Jonathan",
                            LastName = "Demme"
                        },
                        new
                        {
                            DirectorId = 4,
                            FirstName = "Francis",
                            LastName = "Coppola"
                        },
                        new
                        {
                            DirectorId = 5,
                            FirstName = "Quentin",
                            LastName = "Tarantino"
                        },
                        new
                        {
                            DirectorId = 6,
                            FirstName = "Guillermo",
                            LastName = "del Toro"
                        },
                        new
                        {
                            DirectorId = 7,
                            FirstName = "Hayao",
                            LastName = "Miyazaki"
                        },
                        new
                        {
                            DirectorId = 8,
                            FirstName = "Ridley",
                            LastName = "Scott"
                        },
                        new
                        {
                            DirectorId = 9,
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        });
                });

            modelBuilder.Entity("MovieStore.Data.Models.DirectorMovie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "DirectorId");

                    b.HasIndex("DirectorId");

                    b.ToTable("DirectorMovies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            DirectorId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            DirectorId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            DirectorId = 3
                        },
                        new
                        {
                            MovieId = 4,
                            DirectorId = 4
                        },
                        new
                        {
                            MovieId = 5,
                            DirectorId = 5
                        },
                        new
                        {
                            MovieId = 6,
                            DirectorId = 6
                        },
                        new
                        {
                            MovieId = 7,
                            DirectorId = 7
                        },
                        new
                        {
                            MovieId = 8,
                            DirectorId = 8
                        },
                        new
                        {
                            MovieId = 9,
                            DirectorId = 5
                        },
                        new
                        {
                            MovieId = 10,
                            DirectorId = 9
                        });
                });

            modelBuilder.Entity("MovieStore.Data.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<double>("Runtime")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Genre = "Drama",
                            Runtime = 144.0,
                            Title = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            MovieId = 2,
                            Genre = "Mystery",
                            Runtime = 127.0,
                            Title = "Se7en",
                            Year = 1995
                        },
                        new
                        {
                            MovieId = 3,
                            Genre = "Thriller",
                            Runtime = 118.0,
                            Title = "The Silence of the Lambs",
                            Year = 1991
                        },
                        new
                        {
                            MovieId = 4,
                            Genre = "Crime",
                            Runtime = 175.0,
                            Title = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            MovieId = 5,
                            Genre = "Adventure",
                            Runtime = 153.0,
                            Title = "Inglourious Basterds",
                            Year = 2009
                        },
                        new
                        {
                            MovieId = 6,
                            Genre = "Fantasy",
                            Runtime = 118.0,
                            Title = "Pan's Labyrinth",
                            Year = 2006
                        },
                        new
                        {
                            MovieId = 7,
                            Genre = "Animation",
                            Runtime = 125.0,
                            Title = "Spirited Away",
                            Year = 2001
                        },
                        new
                        {
                            MovieId = 8,
                            Genre = "Action",
                            Runtime = 155.0,
                            Title = "Gladiator",
                            Year = 2000
                        },
                        new
                        {
                            MovieId = 9,
                            Genre = "Western",
                            Runtime = 165.0,
                            Title = "Django Unchained",
                            Year = 2012
                        },
                        new
                        {
                            MovieId = 10,
                            Genre = "Sci-Fi",
                            Runtime = 148.0,
                            Title = "Inception",
                            Year = 2010
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieStore.Data.Models.Actor", b =>
                {
                    b.HasOne("MovieStore.Data.Models.Movie", null)
                        .WithMany("Actors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieStore.Data.Models.ActorMovie", b =>
                {
                    b.HasOne("MovieStore.Data.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieStore.Data.Models.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieStore.Data.Models.CheckedOutMovies", b =>
                {
                    b.HasOne("MovieStore.Data.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MovieStore.Data.Models.Director", b =>
                {
                    b.HasOne("MovieStore.Data.Models.Movie", null)
                        .WithMany("Directors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieStore.Data.Models.DirectorMovie", b =>
                {
                    b.HasOne("MovieStore.Data.Models.Director", "Director")
                        .WithMany("DirectorMovies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieStore.Data.Models.Movie", "Movie")
                        .WithMany("DirectorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
