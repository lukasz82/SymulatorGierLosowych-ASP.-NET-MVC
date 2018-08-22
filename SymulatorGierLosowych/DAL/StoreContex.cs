using SymulatorGierLosowych.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.DAL
{
    public class StoreContex : DbContext
    {
        public StoreContex() : base("StoreContex")
        {

        }

        static StoreContex()
        {
            // Inicjalizator automatycznych wpisów do bazy danych
            Database.SetInitializer<StoreContex>(new StoreInitializer());
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<GameGenre> GameGenres { get; set; }
    }
}