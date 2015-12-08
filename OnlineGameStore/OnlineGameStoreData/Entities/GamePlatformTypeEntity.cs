using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GamePlatformTypeEntity
    {
        [Key]
        public int GameId { get; set; }
        public int TypeId { get; set; }

        public GameEntity Game { get; set; }
        public ICollection<PlatformTypeEntity> Types { get; set; }
    }
}