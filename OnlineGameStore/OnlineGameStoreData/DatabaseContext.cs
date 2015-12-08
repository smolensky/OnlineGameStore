using System.Data.Entity;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData
{
    public class DatabaseContext : DbContext
    {
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<PlatformTypeEntity> PlatformTypes { get; set; }
        public DbSet<GameGenreEntity> GameGenres { get; set; }
        public DbSet<GamePlatformTypeEntity> GamePlatformTypes { get; set; }
    }
}
