using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class CommentEntity
    {
        [Key]
        public string Name { get; set; }
        public string Body { get; set; }
        public string ParentName { get; set; }

        public GameEntity Game { get; set; }
    }
}