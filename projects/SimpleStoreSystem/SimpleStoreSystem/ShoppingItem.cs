using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    // This is the base class for inheritance
    public class ShoppingItem
    {
        public int _itemID;
        public string _itemTitle;
        public string _itemDescription;
        public decimal _price;
        public bool _sold;
        public StoreOwner _owner;
        public decimal Price 
        { 
            get
            {
                return _price;
            } 
            set
            {
                if(value < 0 || value > 1000000)    //value cannot be negative or over 1000000
                {
                    throw new ArgumentOutOfRangeException("Error: Invalid price.", "price");
                }
                _price = value;
            } 
        }
        
        public ShoppingItem() { }

        public ShoppingItem(int itemID, string itemTitle, string itemDescription, decimal price)
        {
            _itemID = itemID;
            _itemTitle = itemTitle;
            _itemDescription = itemDescription;
            Price = price;
            _sold = false;
        }

        public virtual void PrintInfo()
        {
            System.Console.WriteLine("Item ID: " + _itemID);
            System.Console.WriteLine("Item Title: " + _itemTitle);
            System.Console.WriteLine("Item Description: " + _itemDescription);
            System.Console.WriteLine("Item Price: " + Price);
        }
    }
}
