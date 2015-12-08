using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace OnlineGameStoreData.Entities
{
    public class GameEntity
    {
        [Key]
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<CommentEntity> Comments { get; set; } 
    }
}
