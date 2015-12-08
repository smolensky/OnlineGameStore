using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class CommentEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int? ParentId { get; set; }

        public GameEntity Game { get; set; }
    }
}