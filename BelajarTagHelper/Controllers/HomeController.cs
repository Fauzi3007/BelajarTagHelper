using BelajarTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace BelajarTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private List<Student> listStudents;
        public HomeController()
        {

            listStudents = new List<Student>()
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
        }
        public ViewResult Index()
        {
            return View(listStudents);
        }

        public ViewResult Details(int Id)
        {
            var studentDetails = listStudents.FirstOrDefault(std => std.StudentId == Id);

            return View(studentDetails);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}