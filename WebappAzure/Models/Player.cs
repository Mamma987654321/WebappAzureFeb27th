using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebappAzure.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Team { get; set; }
    }
}
