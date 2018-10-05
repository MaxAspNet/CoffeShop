using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aprel.Models;


namespace Aprel.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        CoffeeContext db = new CoffeeContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Napitki()
        {
            IEnumerable<Item> Napitki = db.Napitki;

            return View(Napitki.ToList());
        }
        public ActionResult NapitokDetails(int id)
        {
            IEnumerable<Item> Napitki = db.Napitki;
            var Napitok = Napitki.FirstOrDefault(a => a.Id == id);

            return View(Napitok);
        }

        public ActionResult Coffeemachines()
        {

            IEnumerable<Item> Coffeemachines = db.Coffeemachines;

            return View(Coffeemachines.ToList());
        }
        public ActionResult CoffeemachineDetails(int id)
        {
            IEnumerable<Item> Coffeemachines = db.Coffeemachines;
            var Coffeemachine = Coffeemachines.FirstOrDefault(a => a.Id == id);

            return View(Coffeemachine);
        }


        public ActionResult Accessories()
        {
            IEnumerable<Item> Accessories = db.Accessories;

            return View(Accessories.ToList());
        }

        public ActionResult AccessorDetails(int id)
        {
            IEnumerable<Item> Accessories = db.Accessories;
            var Accessor = Accessories.FirstOrDefault(a => a.Id == id);

            return View(Accessor);
        }




        public ActionResult Help()
        {
            IEnumerable<Item> CoffeemachinesClasses = db.CoffeemachinesClasses;

            return View(CoffeemachinesClasses.ToList());
        }

        public ActionResult Dostavka()
        {


            return View();
        }

        public ActionResult Politic()
        {


            return View();
        }

        public ActionResult Coocies()
        {


            return View();
        }
        public ActionResult Contact()
        {


            return View();
        }

        public ActionResult FAQ()
        {


            return View();
        }

        public ActionResult Conditions()
        {


            return View();
        }

        public ActionResult Akcii()
        {


            return View();
        }


        public ActionResult AjaxExample()
        {
           // var data = new { Name = "kevin", Age = 40 };
            return Json("SOME TEXT", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetAjaxHtml(string color, int price = 0)
        {
            IEnumerable<Item> Coffeemachines = db.Coffeemachines.Where(x=>x.Price > price);

                                                                                                                                 //return PartialView("~/Views/Home/Coffeemachines.cshtml", Coffeemachines.ToList());
            return PartialView("~/Views/Home/_Coffeemachines.cshtml", Coffeemachines.ToList());
        }
        [HttpPost]
        public ActionResult GetAjaxHtml1(string color, int price = 0)
        {
            IEnumerable<Item> Napitki = db.Napitki.Where(x => x.Price > price);
            return PartialView("~/Views/Home/_Napitki.cshtml", Napitki.ToList());
        }
        [HttpPost]
        public ActionResult GetAjaxHtml2(string color, int price = 0)
        {
            IEnumerable<Item> Accessories = db.Accessories.Where(x => x.Price > price);
            return PartialView("~/Views/Home/_Napitki.cshtml", Accessories.ToList());
        }
        public ActionResult GetAjaxHtml3( int price1 = 0, int price2 = 0, ItemType typeItem1 = 0, ItemType typeItem2 = 0, ItemType typeItem3 = 0)
        {
           
            IEnumerable<Item> Accessories = db.Accessories.Where(x => x.Price > price1 && x.Price < price2 && (x.ItemType == typeItem1 || x.ItemType == typeItem2 || x.ItemType == typeItem3));
            if (!Accessories.Any()) return Content("<h3>       Не найдено ни одного товара.</h3><hr><br><br><br><br><br>");
            return PartialView("~/Views/Home/_Accessories.cshtml", Accessories.ToList());
        }

        public ActionResult GetAjaxHtml4(int price1 = 0, int price2 = 0, ItemType typeItem1 = 0, ItemType typeItem2 = 0, ItemType typeItem3 = 0)
        {
            IEnumerable<Item> Coffeemachines = db.Coffeemachines.Where(x => x.Price > price1 && x.Price < price2 && (x.ItemType == typeItem1 || x.ItemType == typeItem2 || x.ItemType == typeItem3));
            if (!Coffeemachines.Any()) return Content("<h3>       Не найдено ни одного товара.</h3><hr><br><br><br><br><br>");
            return PartialView("~/Views/Home/_Coffeemachines.cshtml", Coffeemachines.ToList());
        }

        public ActionResult GetAjaxHtml5(int price1 = 0, int price2 = 0, ItemType typeItem1 = 0, ItemType typeItem2 = 0, ItemType typeItem3 = 0)
        {


            IEnumerable<Item> Napitki = db.Napitki.Where(x => x.Price > price1 && x.Price < price2 && (x.ItemType == typeItem1 || x.ItemType == typeItem2 || x.ItemType == typeItem3));

            if (!Napitki.Any()) return Content("<h3>       Не найдено ни одного товара.</h3><hr><br><br><br><br><br>");
            return PartialView("~/Views/Home/_Napitki.cshtml", Napitki.ToList());
        }


        //public ActionResult GetAjaxComment( string CommentUser)
        //{
        //    //db.Comments.Add(new Comment() { ContentComment= CommentUser } );
        //    db.Comments.Add(  CommentUser);
        //    return PartialView("~/Views/Home/_Napitki.cshtml", CommentUser);
        //}

    }
}
