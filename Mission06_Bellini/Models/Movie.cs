using System.ComponentModel.DataAnnotations;

namespace Mission06_Bellini.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; } 

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, 3000)]
        public int Year { get; set; }  // Made non-nullable + required

        public string? Director { get; set; }

        public string? Rating { get; set; }

        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }

        public bool CopiedToPlex { get; set; }
    }
}
