using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BashCVPortfolio.Models;

namespace BashCVPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var profile = new PersonalInfo
            {
                FullName = "Bash Benshak Haruna",

                ProfessionalTitle =
                    "Computer Engineer | Backend Developer | ICT Educator",

                ProfessionalSummary =
                    "I am a Computer Engineering graduate with experience " +
                    "in ICT education, software development and backend " +
                    "application development. I enjoy building practical " +
                    "technology solutions and helping others develop " +
                    "their digital skills.",

                Location = "Nigeria",

                Email = "benshakharuna23@gmail.com",

                Phone = "+2348167037439",

                GitHubUrl = "https://github.com/benbash",

                LinkedInUrl = "https://linkedin.com/in/bash-benshak-haruna"
            };

            return View(profile);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            var about = new AboutMe
            {
                Biography =
                    "I am a Computer Engineering graduate with experience " +
                    "in ICT education, software development and technology. " +
                    "I have a passion for building practical software " +
                    "solutions and helping people develop digital skills.",

                CareerObjective =
                    "My goal is to grow as a professional software developer, " +
                    "particularly in backend development and .NET technologies.",

                ProfessionalInterests = new List<string>
        {
            "Backend Development",
            "Software Engineering",
            "Artificial Intelligence",
            "Technology Education"
        }
            };

            return View(about);
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
    {
        new Skill
        {
            Category = "Backend Development",

            SkillNames = new List<string>
            {
                "C# still learning",
                "ASP.NET Core MVC still learning",
                "Node.js",
                "Express.js",
                "REST API Development"
            }
        },

        new Skill
        {
            Category = "Frontend Development",

            SkillNames = new List<string>
            {
                "HTML5",
                "CSS3",
                "JavaScript",
                "React",
                "Bootstrap"
            }
        },

        new Skill
        {
            Category = "Database Management",

            SkillNames = new List<string>
            {
                "MongoDB",
                "Mongoose",
                "SQL"
            }
        },

        new Skill
        {
            Category = "Development Tools",

            SkillNames = new List<string>
            {
                "Visual Studio",
                "Visual Studio Code",
                "Git",
                "GitHub",
                "Postman"
            }
        }
    };

            return View(skills);
        }

        public IActionResult Education()
        {
            var education = new List<Education>
    {
        new Education
        {
            Qualification = "B.Eng. Computer Engineering",

            Institution = "University of Benin",

            Year = "2017",

            Description = "Studied Computer Engineering."
        },

        new Education
        {
            Qualification = "Professional Training",

            Institution = "TechCrush Bootcamp",

            Year = "2026",

            Description = "Backend development training covering " +
                          "Node.js, Express.js, MongoDB and REST APIs."
        }
    };

            return View(education);
        }

        public IActionResult Experience()
        {
            var experiences = new List<Experience>
    {
        // Software Development Experience

        new Experience
        {
            JobTitle = "Web Developer Intern",

            Organization = "Codveda Technologies",

            Location = "Remote",

            EmploymentPeriod = "July – August 2026",

            Category = "Software Development",

            Description = "Participated in a remote web development internship " +
                          "focused on building responsive web interfaces.",

            Responsibilities = new List<string>
            {
                "Developed static webpages and portfolio interfaces.",
                "Worked with HTML, CSS and JavaScript.",
                "Practised debugging and version control.",
                "Worked on assigned web development tasks."
            }
        },

        // Teaching and ICT Experience

        new Experience
        {
            JobTitle = "ICT Teacher / Server Administrator / House Master",

            Organization = "Charis International College",

            Location = "Nigeria",

            EmploymentPeriod = "September 2020 – March 2026",

            Category = "Teaching and ICT",

            Description = "Combined ICT education, computer systems support " +
                          "and student supervision responsibilities.",

            Responsibilities = new List<string>
            {
                "Taught ICT and Data Processing from JSS1 to SSS3.",
                "Delivered practical computer laboratory sessions.",
                "Supported computer maintenance and ICT operations.",
                "Supervised students and supported hostel administration."
            }
        },

        new Experience
        {
            JobTitle = "Computer Instructor",

            Organization = "Divine Master Computer Academy",

            Location = "Nigeria",

            EmploymentPeriod = "August – September 2020",

            Category = "Teaching and ICT",

            Description = "Provided computer instruction and practical " +
                          "learning support to students.",

            Responsibilities = new List<string>
            {
                "Delivered computer instruction.",
                "Supported learners in developing practical computer skills."
            }
        },

        new Experience
        {
            JobTitle = "Computer Studies Teacher / Laboratory Instructor",

            Organization = "Pen Resource Academy",

            Location = "Gombe, Nigeria",

            EmploymentPeriod = "November 2019 – March 2020",

            Category = "Teaching and ICT",

            Description = "Delivered Computer Studies education and " +
                          "supported practical laboratory activities.",

            Responsibilities = new List<string>
            {
                "Taught Computer Studies.",
                "Conducted practical computer laboratory sessions.",
                "Supported computer laboratory operations."
            }
        },

        new Experience
        {
            JobTitle = "Computer Studies Teacher",

            Organization = "Kanadi Academy",

            Location = "Gombe, Nigeria",

            EmploymentPeriod = "May – October 2019",

            Category = "Teaching and ICT",

            Description = "Provided Computer Studies instruction " +
                          "and practical learning support.",

            Responsibilities = new List<string>
            {
                "Taught Computer Studies.",
                "Supported students in practical computer learning."
            }
        },

        // National Service

        new Experience
        {
            JobTitle = "NYSC Corp Member",

            Organization = "Gombe State Ministry of Science and Technology",

            Location = "Gombe, Nigeria",

            EmploymentPeriod = "October 2018 – September 2019",

            Category = "National Service",

            Description = "Completed the National Youth Service Corps " +
                          "programme at the Gombe State Ministry of Science " +
                          "and Technology.",

            Responsibilities = new List<string>
            {
                "Completed assigned national service responsibilities."
            }
        },

        // Leadership and Volunteer Experience

        new Experience
        {
            JobTitle = "Volunteer Staff",

            Organization = "Calvary Ministries (CAPRO)",

            Location = "Nigeria",

            EmploymentPeriod = "November 2017 – November 2018",

            Category = "Leadership and Volunteering",

            Description = "Participated in volunteer service and organisational activities."
        },

        new Experience
        {
            JobTitle = "State Evangelism Secretary",

            Organization = "NCCF Gombe",

            Location = "Gombe, Nigeria",

            EmploymentPeriod = "February – May 2019",

            Category = "Leadership and Volunteering",

            Description = "Served in a state-level evangelism leadership position."
        },

        new Experience
        {
            JobTitle = "Coordinator",

            Organization = "Association of Christian Students in Missions",

            Location = "Nigeria",

            EmploymentPeriod = "August 2014 – August 2015",

            Category = "Leadership and Volunteering",

            Description = "Served as a coordinator within the student missions association."
        }
    };

            return View(experiences);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
    {
        new Project
        {
            ProjectName = "MealMate API",

            Category = "Backend Development",

            Description =
                "A backend REST API developed for a meal and restaurant " +
                "management platform. The application supports vendor, " +
                "kitchen and meal management.",

            Technologies = new[]
            {
                "Node.js",
                "Express.js",
                "MongoDB",
                "Mongoose",
                "JWT"
            },

            KeyFeatures = new[]
            {
                "Vendor management",
                "Kitchen management",
                "Meal and category management",
                "Meal availability management",
                "Input validation and error handling"
            },

            GitHubUrl = "https://github.com/benbash/Codveda-Internship/tree/level-3-task-1",
            LiveDemoUrl = ""
        },

        new Project
        {
            ProjectName = "FindIt API",

            Category = "Backend Development",

            Description =
                "A community Lost and Found REST API designed to help " +
                "users report, manage and recover lost belongings.",

            Technologies = new[]
            {
                "Node.js",
                "Express.js",
                "MongoDB",
                "Mongoose",
                "JWT"
            },

            KeyFeatures = new[]
            {
                "User authentication",
                "JWT-based authorization",
                "Password reset functionality",
                "Lost and found management",
                "Request validation"
            },

            GitHubUrl = "https://github.com/benbash/FindIt-API",
            LiveDemoUrl = ""
        },

        new Project
        {
            ProjectName = "Student Gradebook API",

            Category = "Backend Development",

            Description =
                "An API project focused on student grade management, " +
                "structured data handling and validation.",

            Technologies = new[]
            {
                "Node.js",
                "Express.js",
                "JavaScript"
            },

            KeyFeatures = new[]
            {
                "Grade management",
                "Input validation",
                "Structured API responses"
            },

            GitHubUrl = "https://github.com/benbash/Student-Gradebook-API",
            LiveDemoUrl = ""
        },

        new Project
        {
            ProjectName = "Finsweet Website Clone",

            Category = "Frontend Development",

            Description =
                "A frontend website recreation demonstrating responsive " +
                "web design and practical frontend development skills.",

            Technologies = new[]
            {
                "HTML5",
                "CSS3",
                "JavaScript"
            },

            KeyFeatures = new[]
            {
                "Responsive webpage design",
                "Structured page layouts",
                "CSS styling",
                "Frontend implementation"
            },

            GitHubUrl = "https://github.com/benbash/Finsweet",
            LiveDemoUrl = "https://benbash.github.io/Finsweet/"
        },

        new Project
        {
            ProjectName = "JavaScript To-do List",

            Category = "Frontend Development",

            Description =
                "A task management application developed to demonstrate " +
                "JavaScript programming and interactive user interfaces.",

            Technologies = new[]
            {
                "HTML5",
                "CSS3",
                "JavaScript"
            },

            KeyFeatures = new[]
            {
                "Task creation",
                "Task listing",
                "Task management",
                "Interactive user interface"
            },

            GitHubUrl = "https://github.com/benbash/Codveda-Internship/tree/level-2-task-2",
            LiveDemoUrl = "https://benbash.github.io/Codveda-Internship/"
        },

        new Project
{
    ProjectName = "Terra-clone",

    Category = "Frontend Development",

    Description =
        "A responsive website recreation project developed " +
        "to demonstrate frontend development skills, " +
        "web layout implementation and responsive design.",

    Technologies = new[]
    {
        "HTML5",
        "CSS3",
        "JavaScript"
    },

    KeyFeatures = new[]
    {
        "Responsive website layout",
        "Structured HTML implementation",
        "Custom CSS styling",
        "JavaScript interactions"
    },

    GitHubUrl = "https://github.com/benbash/Terra-clone",

    LiveDemoUrl = "https://benbash.github.io/Terra-clone/"
}

    };



            return View(projects);
        }

        // Display the Contact page
        //public IActionResult Contact()
        //{
        //    return View(new ContactViewModel());
        //}

        // Process the Contact form
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Contact(ContactViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData["SuccessMessage"] =
        //            "Your message passed validation. Email delivery will be configured in a later lesson.";

        //        return RedirectToAction(nameof(Contact));
        //    }

        //    return View(model);
        //}
    }
}