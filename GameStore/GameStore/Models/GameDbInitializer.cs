using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Drawing;

namespace GameStore.Models
{
    public class GameDbInitializer : DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext db)
        {
            db.Games.Add(new Game { Name = "GTA 5", Company = "Rockstar", Price = 39.99, Description = "Grand Theft Auto V is an action-adventure video game developed by Rockstar North and published by Rockstar Games." });
            db.Games.Add(new Game { Name = "Watch Dogs 2", Company = "Ubisoft", Price = 42.99, Description = "Watch Dogs 2  is an open-world action-adventure third-person video game" });
            db.Games.Add(new Game { Name = "Minecraft", Company = "Mojang", Price = 9.99, Description = "Minecraft is a sandbox video game originally created by Swedish game designer Markus 'Notch' Persson, and later fully developed and published by Mojang." });
            //db.Games.Add(new Game { Name = "Scrap Mechanic", Company = "Axolot", Price = 12.49, Description = "Scrap Mechanic is an all-new creative multiplayer sandbox game where you explore, scavenge and collect objects from all over a wide-open interactive world. " });

            base.Seed(db);
        }
    }
}