namespace FinalProject.Models
{
    public class Resort
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int VerticalDrop { get; set; }
        public int NumRuns { get; set; }
        public string Difficulty { get; set; } = string.Empty;
    }
}
