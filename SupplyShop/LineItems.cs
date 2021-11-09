using SupplyShopModels;
using System.ComponentModel.DataAnnotations;

namespace SupplyShop
{
    public class LineItems
    {
        private int _lineItemID;
        [Key]
        public  int LineItemID 
        {
            get { return _lineItemID; }

            set 
            { 
                _lineItemID = value ;
                
            }
        
        }
       

       private int _quantity;
       public int Quantity
       {
           get { return _quantity; }
           set { _quantity = value; }
       }

       private int _productID;
       public int ProductID
       {
           get { return _productID; }
           set { _productID = value; }
       }

       private int _ordersid;
       public int OrdersID
       {
           get { return _ordersid; }
           set { _ordersid = value; }
       }
       

       public virtual Orders Orders {get; set;}

       public virtual Items Product {get; set;}
       
       
       
       
    }

}