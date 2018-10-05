using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aprel.Models;

namespace Aprel.Controllers
{
    public class CartController : Controller
    {
        private IBookRepository repository;

        public CartController() : this(new EFBookRepository())
        { }

        public CartController(IBookRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public RedirectToRouteResult AddNapitkiToCart(int Id, string returnUrl)
        {
            Item book = repository.Napitki
                .FirstOrDefault(b => b.Id == Id);

            if (book != null)
            {
                GetCart().AddItem(book, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveNapitkiFromCart(int bookId, string returnUrl)
        {
            Item book = repository.Napitki
                .FirstOrDefault(b => b.Id == bookId);

            if (book != null)
            {
                GetCart().RemoveLine(book);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult AddCoffeemachinesToCart(int Id, string returnUrl)
        {
            Item book = repository.Coffeemachines
                .FirstOrDefault(b => b.Id == Id);

            if (book != null)
            {
                GetCart().AddItem(book, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveCoffeemachinesFromCart(int bookId, string returnUrl)
        {
            Item book = repository.Coffeemachines
                .FirstOrDefault(b => b.Id == bookId);

            if (book != null)
            {
                GetCart().RemoveLine(book);
            }

            return RedirectToAction("Index", new { returnUrl });
        }




        public RedirectToRouteResult AddAccessoriesToCart(int Id, string returnUrl)
        {
            Item book = repository.Accessories
                .FirstOrDefault(b => b.Id == Id);

            if (book != null)
            {
                GetCart().AddItem(book, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveAccessoriesFromCart(int bookId, string returnUrl)
        {
            Item book = repository.Accessories
                .FirstOrDefault(b => b.Id == bookId);

            if (book != null)
            {
                GetCart().RemoveLine(book);
            }

            return RedirectToAction("Index", new { returnUrl });
        }





    }
}