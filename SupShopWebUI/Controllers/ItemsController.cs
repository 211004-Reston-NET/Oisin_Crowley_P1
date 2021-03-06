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
    public class ItemsController : Controller
    {

        private IItemsBL _itemsBL;

        public ItemsController(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;
        }


        // GET: ItemsController
        public ActionResult Index()
        {
            return View(_itemsBL.GetAllItems()
                .Select(it => new ItemsVM(it)).ToList()
                );
        }

        // GET: ItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemsController/Create
        public ActionResult Create()
        {
            return View();
        }


        

        public IActionResult Search(string searchString)
        {
            var items = from it in _itemsBL.GetAllItems()
                        select it;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => i.itemName.Contains(searchString));
            }

            return View(items.ToList());
        }

        // POST: ItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemsVM itVM)
        {
           if(ModelState.IsValid)
            {
                _itemsBL.AddItems(new Items()
                {
                    itemName = itVM.itemName,
                    itemPrice = itVM.itemPrice,
                    itemQuanity = itVM.itemQuanity,
                    ItemDesc = itVM.itemDesc,
                    StoreID = itVM.StoreID,
                    Category = itVM.Category
                });
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: ItemsController/Edit/5
        public ActionResult Edit(int p_id)
        {
            return View(new ItemsVM(_itemsBL.GetProductbyID(p_id)));
        }

        // POST: ItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemsVM it)
        {

            try
            {
                Items Itemsobj = _itemsBL.GetProductbyID(it.ProductID);

                Itemsobj.itemQuanity = it.itemQuanity;

                //Items item = new Items()
                //{
                //    ProductID = it.ProductID,
                //    itemName = it.itemName,
                //    Category = it.Category,
                //    itemPrice = it.itemPrice,
                //    itemQuanity = it.itemQuanity,
                //    ItemDesc = it.itemDesc,
                //    StoreID = it.StoreID

                //};
            
            
                
                    
            
            _itemsBL.UpdateInventory(Itemsobj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }
    

        // GET: ItemsController/Delete/5
        public ActionResult Delete(int p_id)
        {
            //passing the products to the delete view 
            return View(new ItemsVM(_itemsBL.GetProductbyID(p_id)));
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ProductID, IFormCollection collection)
        {
            try
            {
                Items itToBeDeleted = _itemsBL.GetProductbyID(ProductID);
                _itemsBL.DeleteItems(itToBeDeleted);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
