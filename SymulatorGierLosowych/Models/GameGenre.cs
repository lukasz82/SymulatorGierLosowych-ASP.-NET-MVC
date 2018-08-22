using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.Models
{
    public class GameGenre
    {
        // Np Gry Liczowe typu lotto, gry karciane, gry na automatach
        public int GameGenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public string GenreImage { get; set; }
        public string ShortDescription { get; set; }
        // Właściwość - klucz obcy - jeden do wielu, jeden gatunek do wielu gier
        public virtual ICollection<Game> Games { get; set; }
    }
}