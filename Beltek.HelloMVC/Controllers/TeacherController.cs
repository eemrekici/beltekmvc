using Beltek.HelloMVC.Models;
using Beltek.HelloMVC.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Beltek.HelloMVC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ListTeacher");
        }

        [HttpGet]
        public IActionResult AddTeacher() 
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult AddTeacher(Ogretmen ogrt)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogretmenler.Add(ogrt);
                ctx.SaveChanges();

            }
            return RedirectToAction("ListTeacher");

        }

        public IActionResult ListTeacher()
        {
            List<Ogretmen> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogretmenler.ToList();

            }
            return View(lst);
        }
        
        public IActionResult DeleteTeacher(int ogretmenid) 
        {
            using (var ctx = new OkulDbContext())
            {
                var ogrt = ctx.Ogretmenler.Find(ogretmenid);
                ctx.Ogretmenler.Remove(ogrt);
                ctx.SaveChanges();

            }
            return RedirectToAction("ListTeacher");
        }
        
        public IActionResult UpdateTeaher(int ogretmenid) 
        {
            Ogretmen ogrt;

            using (var ctx = new OkulDbContext()) 
            {
                ogrt = ctx.Ogretmenler.Find(ogretmenid);
                
            }
            return View(ogrt);
        }

        [HttpPost]
        public IActionResult UpdateTeacher(Ogretmen ogrt) 
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogrt).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("ListTeacher");
        }


    }
}
