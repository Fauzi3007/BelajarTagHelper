using BelajarTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace TagHelpersDemo.Controllers
{
    public class HomeController : Controller
    {
        private List<Student> listStudents;
        public HomeController()
        {

            listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = Branch.CSE, Gender = Gender.Male, Address = "A1-2018", Email = "James@g.com" },
               new Student() { StudentId = 102, Name = "Priyanka", Branch = Branch.ETC, Gender = Gender.Female, Address = "A1-2019", Email = "Priyanka@g.com" },
               new Student() { StudentId = 103, Name = "David", Branch = Branch.CSE, Gender = Gender.Male, Address = "A1-2020", Email = "David@g.com" },
               new Student() { StudentId = 104, Name = "Pranaya", Branch = Branch.Mech, Gender = Gender.Male, Address = "A1-2021", Email = "Pranaya@g.com" }
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