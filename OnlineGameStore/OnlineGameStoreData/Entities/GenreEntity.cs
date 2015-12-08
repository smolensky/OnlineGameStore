using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GenreEntity
    {
        [Key]
        public int Id { get; set; }
        public string Genre { get; set; }
        public int? ParentId { get; set; }
    }
}