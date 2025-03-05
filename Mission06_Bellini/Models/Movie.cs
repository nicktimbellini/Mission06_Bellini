using System.ComponentModel.DataAnnotations;

namespace Mission06_Bellini.Models // ✅ Ensure this matches your project name
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty; // ✅ Fix non-nullable warning

        [Required]
        public string Category { get; set; } = string.Empty; // ✅ Fix non-nullable warning

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty; // ✅ Fix non-nullable warning

        [Required]
        public string Rating { get; set; } = string.Empty; // ✅ Fix non-nullable warning

        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
