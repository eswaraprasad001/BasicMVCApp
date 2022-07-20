using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("student")]
    public class StudentController1 : Controller
    {
        List<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "Ram", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Sam",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Hari",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "kumar" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Risca" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Kailsa" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };


        [Route("display")]
        public IActionResult Index()
        {

            return View(studentList);

        }

        [Route("Add")]
        public IActionResult AddForm()
        {
            return View();
        }

        [Route("AddEmployee")]
        public IActionResult AddEmployee(int studentId, string StudentName, int Age)
        {
            studentList.Add(new() { StudentId = studentId, StudentName = StudentName, Age = Age });

            return View(studentList);
        }
    }
    }

