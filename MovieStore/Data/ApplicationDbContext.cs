using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MovieStore.Data.Models;

namespace MovieStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<DirectorMovie> DirectorMovies { get; set; }
        public DbSet<CheckedOutMovies> CheckedOutMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(m =>
            {
                m.HasKey(_ => _.MovieId);

                m.Property(_ => _.Title)
                .IsRequired()
                .HasMaxLength(50);

                m.Property(_ => _.Genre)
                .IsRequired()
                .HasMaxLength(20);

                m.Property(_ => _.Year)
                .IsRequired();

                m.Property(_ => _.Runtime)
                .IsRequired();
            });

            modelBuilder.Entity<Actor>(a =>
            {
                a.HasKey(_ => _.ActorId);

                a.Property(_ => _.FirstName)
                .IsRequired()
                .HasMaxLength(30);

                a.Property(_ => _.LastName)
                .IsRequired()
                .HasMaxLength(30);
            });

            modelBuilder.Entity<ActorMovie>(am =>
            {
                am.HasKey(_ => new { _.ActorId, _.MovieId });

                am.HasOne(a => a.Movie)
                .WithMany(m => m.ActorMovies)
                .HasForeignKey(a => a.MovieId);

                am.HasOne(m => m.Actor)
                .WithMany(a => a.ActorMovies)
                .HasForeignKey(m => m.ActorId);
            });

            modelBuilder.Entity<Director>(d =>
            {
                d.HasKey(_ => _.DirectorId);

                d.Property(_ => _.FirstName)
                .IsRequired()
                .HasMaxLength(30);

                d.Property(_ => _.LastName)
                .IsRequired()
                .HasMaxLength(30);
            });

            modelBuilder.Entity<DirectorMovie>(dm =>
            {
                dm.HasKey(_ => new { _.MovieId, _.DirectorId });

                dm.HasOne(d => d.Director)
                .WithMany(m => m.DirectorMovies)
                .HasForeignKey(d => d.DirectorId);

                dm.HasOne(m => m.Movie)
                .WithMany(d => d.DirectorMovies)
                .HasForeignKey(m => m.MovieId);
            });

            modelBuilder.Entity<CheckedOutMovies>(cm =>
            {
                cm.HasKey(k => k.CheckedOutMoviesId);
            });

            modelBuilder.Seed();
        }

        
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Database=MovieStore;Trusted_Connection=true";
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            builder.UseSqlServer(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Movies
            var shawshank = new Movie { MovieId = 1, Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994, Runtime = 144 };
            var seven = new Movie { MovieId = 2, Title = "Se7en", Genre = "Mystery", Year = 1995, Runtime = 127 };
            var silence = new Movie { MovieId = 3, Title = "The Silence of the Lambs", Genre = "Thriller", Year = 1991, Runtime = 118 };
            var godfather = new Movie { MovieId = 4, Title = "The Godfather", Genre = "Crime", Year = 1972, Runtime = 175 };
            var basterds = new Movie { MovieId = 5, Title = "Inglourious Basterds", Genre = "Adventure", Year = 2009, Runtime = 153 };
            var pan = new Movie { MovieId = 6, Title = "Pan's Labyrinth", Genre = "Fantasy", Year = 2006, Runtime = 118 };
            var spirit = new Movie { MovieId = 7, Title = "Spirited Away", Genre = "Animation", Year = 2001, Runtime = 125 };
            var gladiator = new Movie { MovieId = 8, Title = "Gladiator", Genre = "Action", Year = 2000, Runtime = 155 };
            var django = new Movie { MovieId = 9, Title = "Django Unchained", Genre = "Western", Year = 2012, Runtime = 165 };
            var inception = new Movie { MovieId = 10, Title = "Inception", Genre = "Sci-Fi", Year = 2010, Runtime = 148 };

            //Actors
            var mFreeman = new Actor { ActorId = 1, FirstName = "Morgan", LastName = "Freeman" };
            var tRobbins = new Actor { ActorId = 2, FirstName = "Tim", LastName = "Robbins" };
            var bGunton = new Actor { ActorId = 3, FirstName = "Bob", LastName = "Gunton" };
            var kSpacey = new Actor { ActorId = 4, FirstName = "Kevin", LastName = "Spacey" };
            var bPitt = new Actor { ActorId = 5, FirstName = "Brad", LastName = "Pitt" };
            var jFoster = new Actor { ActorId = 6, FirstName = "Jodie", LastName = "Foster" };
            var aHopkins = new Actor { ActorId = 7, FirstName = "Anthony", LastName = "Hopkins" };
            var mBrando = new Actor { ActorId = 8, FirstName = "Marlon", LastName = "Brando" };
            var aPacino = new Actor { ActorId = 9, FirstName = "Al", LastName = "Pacino" };
            var cWaltz = new Actor { ActorId = 10, FirstName = "Christopher", LastName = "Waltz" };
            var iBaquero = new Actor { ActorId = 11, FirstName = "Ivana", LastName = "Baquero" };
            var sLopez = new Actor { ActorId = 12, FirstName = "Sergi", LastName = "Lopez" };
            var rHiiragi = new Actor { ActorId = 13, FirstName = "Rumi", LastName = "Hiiragi" };
            var mIrino = new Actor { ActorId = 14, FirstName = "Miyu", LastName = "Irino" };
            var rCrowe = new Actor { ActorId = 15, FirstName = "Russel", LastName = "Crowe" };
            var jPhoenix = new Actor { ActorId = 16, FirstName = "Joaquin", LastName = "Phoenix" };
            var jFoxx = new Actor { ActorId = 17, FirstName = "Jamie", LastName = "Foxx" };
            var lDicaprio = new Actor { ActorId = 18, FirstName = "Leonardo", LastName = "DiCaprio" };
            var jLevitt = new Actor { ActorId = 19, FirstName = "Joseph", LastName = "Gordon-Levitt" };

            //Directors
            var fDarabont = new Director { DirectorId = 1, FirstName = "Frank", LastName = "Darabont" };
            var dFincher = new Director { DirectorId = 2, FirstName = "David", LastName = "Fincher" };
            var jDemme = new Director { DirectorId = 3, FirstName = "Jonathan", LastName = "Demme" };
            var fCoppola = new Director { DirectorId = 4, FirstName = "Francis", LastName = "Coppola" };
            var qTarantino = new Director { DirectorId = 5, FirstName = "Quentin", LastName = "Tarantino" };
            var gToro = new Director { DirectorId = 6, FirstName = "Guillermo", LastName = "del Toro" };
            var hMiyazaki = new Director { DirectorId = 7, FirstName = "Hayao", LastName = "Miyazaki" };
            var rScott = new Director { DirectorId = 8, FirstName = "Ridley", LastName = "Scott" };
            var cNolan = new Director { DirectorId = 9, FirstName = "Christopher", LastName = "Nolan" };

            //ActorMovies
            var shawFreeman = new ActorMovie { MovieId = 1, ActorId = 1 };
            var shawRobbins = new ActorMovie { MovieId = 1, ActorId = 2 };
            var shawGunton = new ActorMovie { MovieId = 1, ActorId = 3 };
            var sevFreeman = new ActorMovie { MovieId = 2, ActorId = 1 };
            var sevSpacey = new ActorMovie { MovieId = 2, ActorId = 4 };
            var sevPitt = new ActorMovie { MovieId = 2, ActorId = 5 };
            var silFoster = new ActorMovie { MovieId = 3, ActorId = 6 };
            var silHopkins = new ActorMovie { MovieId = 3, ActorId = 7 };
            var godBrando = new ActorMovie { MovieId = 4, ActorId = 8 };
            var godPacino = new ActorMovie { MovieId = 4, ActorId = 9 };
            var bastPitt = new ActorMovie { MovieId = 5, ActorId = 5 };
            var bastWaltz = new ActorMovie { MovieId = 5, ActorId = 10 };
            var panBaquero = new ActorMovie { MovieId = 6, ActorId = 11 };
            var panLopez = new ActorMovie { MovieId = 6, ActorId = 12 };
            var spiritHiiragi = new ActorMovie { MovieId = 7, ActorId = 13 };
            var spiritIrino = new ActorMovie { MovieId = 7, ActorId = 14 };
            var gladCrowe = new ActorMovie { MovieId = 8, ActorId = 15 };
            var gladPhoenix = new ActorMovie { MovieId = 8, ActorId = 16 };
            var djangoFoxx = new ActorMovie { MovieId = 9, ActorId = 17 };
            var djangoDicaprio = new ActorMovie { MovieId = 9, ActorId = 18 };
            var djangoWaltz = new ActorMovie { MovieId = 9, ActorId = 10 };
            var inceptionDiCaprio = new ActorMovie { MovieId = 10, ActorId = 18 };
            var inceptionLevitt = new ActorMovie { MovieId = 10, ActorId = 19 };


            //DirectorMovies
            var shawDarabont = new DirectorMovie { MovieId = 1, DirectorId = 1 };
            var sevFincher = new DirectorMovie { MovieId = 2, DirectorId = 2 };
            var silDemme = new DirectorMovie { MovieId = 3, DirectorId = 3 };
            var godCoppola = new DirectorMovie { MovieId = 4, DirectorId = 4 };
            var bastTarantino = new DirectorMovie { MovieId = 5, DirectorId = 5 };
            var panToro = new DirectorMovie { MovieId = 6, DirectorId = 6 };
            var spiritMiyazaki = new DirectorMovie { MovieId = 7, DirectorId = 7 };
            var gladScott = new DirectorMovie { MovieId = 8, DirectorId = 8 };
            var djangoTarantino = new DirectorMovie { MovieId = 9, DirectorId = 5 };
            var inceptionNolan = new DirectorMovie { MovieId = 10, DirectorId = 9 };

            //Seed
            modelBuilder.Entity<Movie>().HasData(shawshank, seven, silence, godfather, basterds, pan, spirit, gladiator, django, inception);
            modelBuilder.Entity<Actor>().HasData(mFreeman, tRobbins, bGunton, kSpacey, bPitt, jFoster, aHopkins, mBrando, aPacino, cWaltz, iBaquero, sLopez,
                rHiiragi, mIrino, rCrowe, jPhoenix, jFoxx, lDicaprio, jLevitt);
            modelBuilder.Entity<Director>().HasData(fDarabont, dFincher, jDemme, fCoppola, qTarantino, gToro, hMiyazaki, rScott, cNolan);
            modelBuilder.Entity<ActorMovie>().HasData(shawFreeman, shawGunton, shawRobbins, sevFreeman, sevSpacey, sevPitt, silFoster, silHopkins,
                godBrando, godPacino, bastPitt, bastWaltz, panBaquero, panLopez, spiritIrino, spiritHiiragi, gladCrowe, gladPhoenix, djangoDicaprio, djangoFoxx,
                djangoWaltz, inceptionDiCaprio, inceptionLevitt);
            modelBuilder.Entity<DirectorMovie>().HasData(shawDarabont, sevFincher, silDemme, godCoppola, bastTarantino, panToro, spiritMiyazaki, gladScott, djangoTarantino, inceptionNolan);
        }
    }
}

