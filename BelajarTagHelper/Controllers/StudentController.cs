using BelajarTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
namespace BelajarTagHelper.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>
        {
            new Student
            {
                StudentId = 1, FullName = "Pranaya Rout", Password = "Password123!",
                DateOfBirth = new DateTime(1990, 1, 1), Gender = Gender.Male, Address = "Test Address 1234",
                Branch = Branch.CSE, TermsAndConditions = true,
                Hobbies = new List<string> { "Reading", "Traveling" },
                Skills = new List<string> { "C#", "SQL" }
            },
            new Student
            {
                StudentId = 2, FullName = "Hina Sharma", Password = "Password123!",
                DateOfBirth = new DateTime(1992, 2, 15), Gender = Gender.Female, Address = "Test Address 1234",
                Branch = Branch.ETC, TermsAndConditions = true,
                Hobbies = new List<string> { "Music", "Traveling" },
                Skills = new List<string> { "Python", "Machine Learning" }
            },
            new Student
            {
                StudentId = 3, FullName = "Anurag Mohanty", Password = "Password123!",
                DateOfBirth = new DateTime(1988, 11, 23), Gender = Gender.Male, Address = "Test Address 1234",
                Branch = Branch.Mechanical, TermsAndConditions = true,
                Hobbies = new List<string> { "Reading", "Music" },
                Skills = new List<string> { "ASP.NET Core", "Oracle" }
            }
        };

        // GET: Student/List
        [HttpGet]
        public IActionResult List()
        {
            return View(students);
        }

        // GET: Student/Details/{id}
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(std => std.StudentId == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Register
        [HttpGet]
        public IActionResult Register()
        {
            var student = new Student
            {
                Hobbies = new List<string>()  
            };

            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music", "Sports", "Photography" };
            ViewBag.Skills = new List<string> { "C#", "Python", "SQL", "Machine Learning", "ASP.NET Core", "Oracle", "Data Analysis" };
            return View(student);
        }

        // POST: Student/Register
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.StudentId = students.Count() + 1;

                students.Add(student);

                return RedirectToAction("List");
            }

            ViewBag.Hobbies = new List<string> { "Reading", "Traveling", "Music", "Sports", "Photography" };
            ViewBag.Skills = new List<string> { "C#", "Python", "SQL", "Machine Learning", "Physics", "Research", "Data Analysis" };

            return View(student);
        }
    }
}