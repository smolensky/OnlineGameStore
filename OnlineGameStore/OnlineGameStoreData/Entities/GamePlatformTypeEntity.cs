using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GamePlatformTypeEntity
    {
        [Key]
        public string GameName { get; set; }
        public string TypeName { get; set; }

        public GameEntity Game { get; set; }
        public ICollection<PlatformTypeEntity> Types { get; set; }
    }
}