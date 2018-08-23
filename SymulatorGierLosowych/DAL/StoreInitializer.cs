using SymulatorGierLosowych.Migrations;
using SymulatorGierLosowych.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace SymulatorGierLosowych.DAL
{
    // Tutaj będę wrzucał przykładowe dane do bazy
    public class StoreInitializer : MigrateDatabaseToLatestVersion<StoreContex, Configuration>
    {
        // Nadpisuję metodę seed 
        //protected override void Seed(StoreContex contex)
        //{
        //    SeedStoreData(contex);
        //    base.Seed(contex);
        //}

        public static void SeedStoreData(StoreContex contex)
        {
            var game_genres = new List<GameGenre>
            {
                new GameGenre() {GameGenreId = 1, GenreName = "Gry Liczbowe", Description = "Gry Typu lotto", GenreImage = "1.png" },
                new GameGenre() {GameGenreId = 2, GenreName = "Gry Na Automatach", Description = "Gry na różnych automatach", GenreImage = "2.png" },
                new GameGenre() {GameGenreId = 3, GenreName = "Gry Karciane", Description = "Gry karciane", GenreImage = "3.png" },
                new GameGenre() {GameGenreId = 4, GenreName = "Gry Inne", Description = "Gry inne", GenreImage = "4.png" }
            };
            //contex.Database.ExecuteSqlCommand("TRUNCATE TABLE [GameGenre]");
            game_genres.ForEach(g => contex.GameGenres.AddOrUpdate(g));
            contex.SaveChanges();

            var games = new List<Game>
            {
                new Game() {GameID = 1, GameName = "Lotto", GameGenreId = 1, Description = "Gra w lotka, opis"},
                new Game() {GameID = 2, GameName = "MiniLotto", GameGenreId = 1, Description = "Gra w mini-lotka, opis"},
                new Game() {GameID = 3, GameName = "EuroJackpot", GameGenreId = 1, Description = "Gra w eurojackpot, opis"},
                new Game() {GameID = 4, GameName = "JAKPOT 6000", GameGenreId = 2, Description = "Gra w JAKPOT 6000 , opis"},
                new Game() {GameID = 5, GameName = "Poker", GameGenreId = 3, Description = "Gra w pokera, opis"},
                new Game() {GameID = 6, GameName = "Brydż", GameGenreId = 3, Description = "Gra w brydża, opis"},
                new Game() {GameID = 7, GameName = "Kierki", GameGenreId = 3, Description = "Gra w brydża, opis"},
            };
            //contex.Database.ExecuteSqlCommand("TRUNCATE TABLE [GameGenre]");
            games.ForEach(g => contex.Games.AddOrUpdate(g));
            contex.SaveChanges();
        }
    }
}