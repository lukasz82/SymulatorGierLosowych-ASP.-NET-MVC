using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public string GenreImage { get; set; }
        // Właściwość - klucz obcy - jeden do wielu, jeden gatunek do wielu gier
        public virtual ICollection<Game> Games { get; set; }
    }
}