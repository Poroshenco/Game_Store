using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameStore.Models
{
    public class GameDbInitializer : DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext db)
        {
            db.Games.Add(new Game { Name = "GTA 5", Company = "Rockstar", Price = 39.99 });
            db.Games.Add(new Game { Name = "Minecraft", Company = "Mojang", Price = 9.99 });
            db.Games.Add(new Game { Name = "Scrap Mechanic", Company = "IDontRemember", Price = 12.49 });
            
            base.Seed(db);
        }
    }
}