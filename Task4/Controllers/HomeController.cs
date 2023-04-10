using Microsoft.AspNetCore.Mvc;
using Task4.Models;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Mvcdemo2Context db = new Mvcdemo2Context();
            var students=db.Students.ToList();
          
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public IActionResult  Create(Student student)
        {
            if (ModelState.IsValid == true)
            {
                Mvcdemo2Context db = new Mvcdemo2Context();
                db.Students.Add(student);
                db.SaveChanges();
               
            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            Mvcdemo2Context db = new Mvcdemo2Context();
            var student=db.Students.Find(Id);


            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {

            Mvcdemo2Context db = new Mvcdemo2Context();
            db.Students.Update(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {

            Mvcdemo2Context db = new Mvcdemo2Context();
            var student = db.Students.Find(Id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
