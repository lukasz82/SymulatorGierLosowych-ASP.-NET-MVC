using SymulatorGierLosowych.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<GameGenre> GameGenres { get; set; }

    }
}