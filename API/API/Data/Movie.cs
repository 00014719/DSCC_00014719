using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Range(0, 5)]
        public float Rating { get; set; }

        public int ReleaseYear { get; set; }

        public string Director { get; set; } = string.Empty;
    }
}
