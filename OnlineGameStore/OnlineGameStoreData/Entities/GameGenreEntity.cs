using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GameGenreEntity
    {
        [Key]
        public string GameName { get; set; }
        public string GenreName { get; set; }

        public GameEntity Game { get; set; }
        public ICollection<GenreEntity> Genres { get; set; }
    }
}