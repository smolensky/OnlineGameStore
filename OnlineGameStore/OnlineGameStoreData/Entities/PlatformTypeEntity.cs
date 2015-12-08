using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class PlatformTypeEntity
    {
        [Key]
        public string Type { get; set; }
    }
}