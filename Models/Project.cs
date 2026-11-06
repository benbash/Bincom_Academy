namespace BashCVPortfolio.Models
{
    public class Project
    {
        public string ProjectName { get; set; } = "";

        public string Description { get; set; } = "";

        public string Category { get; set; } = "";

        public string[] Technologies { get; set; } = [];

        public string[] KeyFeatures { get; set; } = [];

        public string GitHubUrl { get; set; } = "";

        public string LiveDemoUrl { get; set; } = "";
    }
}