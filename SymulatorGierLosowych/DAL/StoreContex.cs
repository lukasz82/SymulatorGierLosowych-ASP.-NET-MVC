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

        public DbSet<Game> Game { get; set; }

        public DbSet<GameGenre> GameGenre { get; set; }
    }
}