using System.Collections.Generic;

namespace BashCVPortfolio.Models
{
    public class Experience
    {
        public string JobTitle { get; set; } = "";

        public string Organization { get; set; } = "";

        public string Location { get; set; } = "";

        public string EmploymentPeriod { get; set; } = "";

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public List<string> Responsibilities { get; set; } = new();
    }
}