using System.ComponentModel.DataAnnotations;

namespace INFORMATIONS.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }

        public string? Team { get; set; }
        public string? Role { get; set; }
        public string? Soloqueue { get; set; }
        public decimal Year { get; set; }
        public string? Img { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
