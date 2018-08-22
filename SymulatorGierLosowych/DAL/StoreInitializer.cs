﻿using SymulatorGierLosowych.Migrations;
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
        }
    }
}