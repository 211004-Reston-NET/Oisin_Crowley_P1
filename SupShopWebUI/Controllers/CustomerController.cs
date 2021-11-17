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
    public class CustomerController : Controller
    {
        private ICustomersBL _custBL;

        public CustomerController(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;
        }
        // GET: CustomerController
        public ActionResult Index(string SearchString = null)
        {
            if (SearchString != null)
            {
                List<Customers> listOfcust = _custBL.GetCustomers(SearchString);

                return View(listOfcust.Select(cust => new CustomerVM(cust)).ToList());
            }
            return View(_custBL.GetAllCustomers()
                .Select(cust => new CustomerVM(cust)).ToList());
        
            }
            

        // GET: CustomerController/Details/5
        public ActionResult Details(int p_id)
        {
            try
            {
            return View(new CustomerVM((_custBL.GetCustomerbyID(p_id))));
            }
            catch
            {
                return View();
            }
            
        }

       

       

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerVM custVM)
        {
           if (ModelState.IsValid)
            {
                _custBL.AddCustomer(new Customers()
                {
                    CustomerName = custVM.CustomerName,
                    CustCity = custVM.CustCity,
                    CustStreetAdd = custVM.CustStreetAdd,
                    CustState = custVM.CustState,
                    CustEmail = custVM.CustEmail,
                    CustPhone = custVM.CustPhone,
                    CustZip = custVM.CustZip
                });
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
