using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GenreEntity
    {
        [Key]
        public string Genre { get; set; }
        public string ParentGenre { get; set; }
    }
}