using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public int GameGenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public string GameImage { get; set; }
        public string Description { get; set; }
        // Właściwość - klucz obcy - jeden do wielu, jeden gatunek do wielu gier
        public virtual Genre Genre { get; set; }
    }
}