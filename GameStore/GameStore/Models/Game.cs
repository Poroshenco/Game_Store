using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Enter name of game")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Enter company of game")]
        public string Company { get; set; }

        [Required (ErrorMessage ="Enter price (Enterprice)")]
        public double Price { get; set; }
    }
}