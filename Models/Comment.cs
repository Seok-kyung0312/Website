using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INFORMATIONS.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        // Foreign Key relationship with Movie model
        public int ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
    }

}
