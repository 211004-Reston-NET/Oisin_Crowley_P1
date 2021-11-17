using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplyShopBL;
using SupplyShopModels;
using SupShopWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupShopWebUI.Controllers
{
    public class OrderController : Controller
    {
        private IOrdersBL _ordersBL;
        private ICustomersBL _custBL;
        private IStoreFrontBL _storeBL;

        public OrderController(IOrdersBL p_ordersBL, ICustomersBL p_custBl, IStoreFrontBL p_storeBL)
        {
            _ordersBL = p_ordersBL;
            _custBL = p_custBl;
            _storeBL = p_storeBL;
        }
        
        // GET: OrderController
        public ActionResult Index()
        {
            return View(_ordersBL.GetAllOrders()
                .Select(it => new OrdersVM(it)).ToList()
                );
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            List<Customers> listOfcust = _custBL.GetAllCustomers();
            List<StoreFront> listofstores = _storeBL.GetAllStores();
            ViewData["cust"] = listOfcust;
            ViewData["stores"] = listofstores;
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            
            try
            {
                Orders order = new Orders(); 
                


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
