using System.Collections.Generic;
namespace BashCVPortfolio.Models
{
    public class AboutMe
    {
        public string Biography { get; set; } = "";

        public string CareerObjective { get; set; } = "";

        public List<string>
        ProfessionalInterests
        { get; set; } = new();
    }
}