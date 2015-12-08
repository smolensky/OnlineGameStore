using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GameGenreEntity
    {
        [Key]
        public int GameId { get; set; }
        public int GenreId { get; set; }

        public GameEntity Game { get; set; }
        public ICollection<GenreEntity> Genres { get; set; }
    }
}