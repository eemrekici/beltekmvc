using Beltek.HelloMVC.Models;
using Beltek.HelloMVC.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Beltek.HelloMVC.Controllers 
{ 


    public class OgretmenController: Controller
    {
        public ViewResult Index() 
        {
            return View();
        }
        public ViewResult OgretmenEkle()
        {
            return View("AddTeacher");
        }


        public ViewResult OgretmenDetay(int ogretmenid)
        {
            Ogrenci ogrenci = null;
            Ogretmen ogretmen = null;

            if (ogretmenid == 1)
            {
                ogretmen = new Ogretmen(1, "Ali", "Veli","elektrik");

            }
            else if (ogretmenid == 2)
            {
                ogretmen = new Ogretmen(2, "Ahmet", "Mehmet","bilgisayar");

            }

            ViewData["ogrt"] = ogretmen;

            ViewBag.student = ogretmen;

            var dto = new OgrenciDTO();
            var ogretmenDTO = new OgretmenDTO();
            dto.Teacher = ogretmen;
            dto.Student = ogrenci;

            return View(dto);
        }

        public ViewResult OgretmenListe()
        {
            var ogrt = new Ogretmen(1, "Ahmet", "Soyad", "elektrik");
            var ogrt1 = new Ogretmen(2, "Ali", "Veli", "elektrik");

            Ogretmen[] ogretmenler = new Ogretmen[2];
            ogretmenler[0] = ogrt;
            ogretmenler[1] = ogrt1;

            ViewData["teachers"] = ogretmenler;
            ViewBag.ogretmenler = ogretmenler;

            return View(ogretmenler);
        }

        public ViewResult TeacherList()
        {
            var ogrt = new Ogretmen(1, "Ahmet", "Soyad","elektrik");
            var ogrt1 = new Ogretmen(2, "Ali", "Veli", "bilgisayar");

            var lst = new List<Ogretmen> { ogrt, ogrt1 };
            return View(lst);
        }
    }
}
