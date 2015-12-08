using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineGameStoreData.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnlineGameStoreData.DatabaseContext context)
        {
            context.PlatformTypes.AddOrUpdate(
                new PlatformTypeEntity { Type = "Mobile"},
                new PlatformTypeEntity { Type = "Desktop"},
                new PlatformTypeEntity { Type = "Console"},
                new PlatformTypeEntity { Type = "Web"}
                );
            context.SaveChanges();

            context.Genres.AddOrUpdate(
                new GenreEntity { Genre = "Strategy" },
                new GenreEntity { Genre = "RPG" },
                new GenreEntity { Genre = "Sports" },
                new GenreEntity { Genre = "Races" },
                new GenreEntity { Genre = "Action" },
                new GenreEntity { Genre = "Adventure" },
                new GenreEntity { Genre = "Puzzle Skill" },
                new GenreEntity { Genre = "Misc" },
                new GenreEntity { Genre = "RTS", ParentGenre = "Strategy" },
                new GenreEntity { Genre = "TBS", ParentGenre = "Strategy" },
                new GenreEntity { Genre = "rally", ParentGenre = "Races" },
                new GenreEntity { Genre = "arcade", ParentGenre = "Races" },
                new GenreEntity { Genre = "formula", ParentGenre = "Races" },
                new GenreEntity { Genre = "off-road", ParentGenre = "Races" },
                new GenreEntity { Genre = "FPS", ParentGenre = "Action" },
                new GenreEntity { Genre = "TPS", ParentGenre = "Action" },
                new GenreEntity { Genre = "Misc.", ParentGenre = "Action" }
                );
        }
    }
}
