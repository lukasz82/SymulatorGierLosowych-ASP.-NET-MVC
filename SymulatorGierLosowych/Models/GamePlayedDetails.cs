﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.Models
{
    public class GamePlayedDetails
    {
        // Szczegóły rozegranej gry
        public int GamePlayedDetailsID { get; set; }
        public int GameId { get; set; }
        public int PlayerID { get; set; }
    }
}