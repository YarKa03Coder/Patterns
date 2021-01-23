using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patterns.Creational.Singleton
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Range(18, 40)]
        public int Age { get; set; }

        public bool? IsCaptain { get; set; }

        public int? TeamId { get; set; }

        public Team Team { get; set; }
    }
}