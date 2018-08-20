using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.Models
{
    public class Game
    {
        public int GameID { get; set; }
        // Max 150 znaków w bazie danych + komunikat o błędzie, etintity framework automatycznie na podstawie tych dnaych przeprowadzi walidaję w formularzach html, requided - wartość pola w bazie nie może być null
        [Required(ErrorMessage = "Podałeś zbyt dużą ilość znaków")]
        [StringLength(150)]
        public string GameName { get; set; }
        public int GameGenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public string GameImage { get; set; }
        public string Description { get; set; }
        // Właściwość - klucz obcy - jeden do wielu, jeden gatunek do wielu gier
        public virtual GameGenre GameGenre { get; set; }
    }
}