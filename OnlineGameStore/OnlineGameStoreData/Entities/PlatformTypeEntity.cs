using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class PlatformTypeEntity
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}