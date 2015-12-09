using System.Collections.Generic;
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
            //Filling Platform types
            context.PlatformTypes.AddOrUpdate(
                new PlatformTypeEntity { Type = "Mobile"},
                new PlatformTypeEntity { Type = "Desktop"},
                new PlatformTypeEntity { Type = "Console"},
                new PlatformTypeEntity { Type = "Web"}
                );
            context.SaveChanges();

            //Filling Genres
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
            context.SaveChanges();

            //Filling Games
            context.Games.AddOrUpdate(
                new GameEntity { Key = "1", Name = "GRID", Description = "Game with cool cars" },
                new GameEntity { Key = "2", Name = "Diablo", Description = "Oldschool RPG" },
                new GameEntity { Key = "3", Name = "Chess", Description = "Just chess" },
                new GameEntity { Key = "4", Name = "The Cave", Description = "Indie game" }
                );
            context.SaveChanges();

            //Filling Comments
            context.Comments.AddOrUpdate(
                new CommentEntity { Name = "Racer", Body = "Awesome game", Game = context.Games.Find("1") },
                new CommentEntity { Name = "Chess_Player", Body = "Still popular", Game = context.Games.Find("3") },
                new CommentEntity { Name = "Chess_Guru", Body = "Agree", ParentName = "Chess_Player", Game = context.Games.Find("3") },
                new CommentEntity { Name = "The Cave", Body = "Perfect story", Game = context.Games.Find("4") }
                );
            context.SaveChanges();

            //Filling Game with Genres binding
            context.GameGenres.AddOrUpdate(
                new GameGenreEntity { Game = context.Games.Find("1"), GameName = context.Games.Find("1").Name, GenreName = "Races"},
                //TODO: game can be with different genres
                //new GameGenreEntity { Game = context.Games.Find("1"), GameName = context.Games.Find("1").Name, GenreName = "arcade"},
                new GameGenreEntity { Game = context.Games.Find("2"), GameName = context.Games.Find("2").Name, GenreName = "RPG"},
                new GameGenreEntity { Game = context.Games.Find("3"), GameName = context.Games.Find("3").Name, GenreName = "Puzzle Skill"},
                new GameGenreEntity { Game = context.Games.Find("4"), GameName = context.Games.Find("4").Name, GenreName = "Adventure"}
                );
            context.SaveChanges();

            //Filling Game with Platform type binding
            context.GamePlatformTypes.AddOrUpdate(
                new GamePlatformTypeEntity { Game = context.Games.Find("1"), GameName = context.Games.Find("1").Name, TypeName = "Desktop" },
                new GamePlatformTypeEntity { Game = context.Games.Find("2"), GameName = context.Games.Find("2").Name, TypeName = "Desktop" },
                new GamePlatformTypeEntity { Game = context.Games.Find("3"), GameName = context.Games.Find("3").Name, TypeName = "Desktop" },
                new GamePlatformTypeEntity { Game = context.Games.Find("4"), GameName = context.Games.Find("4").Name, TypeName = "Desktop" }
                );
            context.SaveChanges();
        }
    }
}
