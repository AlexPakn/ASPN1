using ASPN1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPN1.Controllers;

public class StudentController : Controller
{
    public Student _student = new Student
    {
        DateOfBirthday = DateTime.Now,
        FirstName = "Test",
        LastName = "Test",
        GPA = 5
    };

    public IActionResult GetStudents()
    {
        //ViewBag.Student = _student;
        //ViewData["Student"] = _student;
        return View(_student);
    }

}
