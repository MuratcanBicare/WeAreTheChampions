﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    [Table("Teams")]
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> TeamColors { get; set; }
        public virtual ICollection<Match> Team1Matches { get; set; }
        public virtual ICollection<Match> Team2Matches { get; set; }
    }
}
