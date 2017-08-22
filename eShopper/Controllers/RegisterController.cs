using eShopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eShopper.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        public ActionResult Index()
        {
            RegisterViewModel model = new RegisterViewModel();
            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem
            {
                Text = "Option1",
                Value = "Option1"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Option2",
                Value = "Option2"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Option3",
                Value = "Option3"
            });

            ViewBag.ListItems = listItems;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {
            if (model.SameAsBilling)
            {
                ModelState.Remove("ShippingAddressStreet");
                ModelState.Remove("ShippingAddressCity");
                ModelState.Remove("ShippingAddressCountry");
                ModelState.Remove("ShippingAddressState");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }

            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem
            {
                Text = "Option1",
                Value = "Option1"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Option2",
                Value = "Option2"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Option3",
                Value = "Option3"
            });

            ViewBag.ListItems = listItems;

            return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}