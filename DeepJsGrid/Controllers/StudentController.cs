using DeepJsGrid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Application.Controllers



{
    public class StudentController : Controller
    {
        private readonly StudentDbContext context;
        public StudentController(StudentDbContext context)
        {
            this.context = context;
        }

        public IActionResult StudentIndex()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ReadData()
        {
            var data = context.Students.ToList();
            return Json(data);
        }




        [HttpPost]
        public IActionResult Insert(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();
            return Json("StudentIndex");


        }
        [HttpPut]
        public IActionResult Edit(Student s)
        {
           
           
                context.Students.Update(s);
                context.SaveChanges();
                return Json("StudentIndex");
        }
        [HttpDelete]
        public IActionResult Destroy(Student s)
        {
           context.Students.Remove(s);
            context.SaveChanges();
            return Json("StudentIndex");
        }

    }
}


