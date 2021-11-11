using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SShopWebUI.Models;
using SupplyShopBL;
using SupplyShopModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace SShopWebUI.Controllers
{
    public class StoreFrontController : Controller
    {

        private IStoreFrontBL _storeBL;

        public StoreFrontController(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        // GET: StoreFrontController
        public ActionResult Index()
        {
            //list of stores from business layer 
            //converted that model of stores in a storefrontVM using select method
            // changed it to a list to a TOList()
            return View(_storeBL.GetAllStores()
                .Select(store => new StoreFrontVM(store)).ToList()
                );
        }

        // GET: StoreFrontController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }



        // GET: StoreFrontController/Create
       

        // POST: StoreFrontController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
      public IActionResult Create(StoreFrontVM storeVM)
        {

           // Customers test = new Customers();
            //// _storeBL.AddStoreFront(new Customers()
            // {

            // });

            return View();
        } 
        

        // GET: StoreFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
