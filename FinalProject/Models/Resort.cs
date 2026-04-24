using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Resort
    {
        public int ResortId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string State { get; set; } = string.Empty;

        [Display(Name = "Vertical Drop (ft)")]
        public int VerticalDrop { get; set; }

        [Display(Name = "Number of Runs")]
        public int NumberOfRuns { get; set; }

        [Display(Name = "Avg Annual Snowfall (in)")]
        public int AnnualSnowfall { get; set; }

        [Display(Name = "Best For")]
        public string Difficulty { get; set; } = string.Empty;
    }
}
