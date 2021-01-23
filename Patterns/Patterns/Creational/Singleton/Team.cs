using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patterns.Creational.Singleton
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }
        
        public ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
    }
}