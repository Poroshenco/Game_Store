using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public double Price { get; set; }
    }
}