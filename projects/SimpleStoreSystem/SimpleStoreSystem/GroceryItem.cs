using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public enum GroceryCategory
    {
        Produce,
        Fruit,
        MeatFish,
        Dairy,
        Beverage
    }
    public class GroceryItem : ShoppingItem, ICloneable
    {
        public DateTime _packageDate;
        public DateTime _expirationDate;
        public GroceryCategory _category;

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (value < _packageDate)    //check if value is greater than package date
                {
                    throw new ArgumentException("Expiration date should be greater than Package date.", "expirationDate");
                }
                _expirationDate = value;
            }
        }

        public GroceryItem() { }

        public GroceryItem(int itemID, string itemTitle, string itemDescription, decimal price, GroceryCategory category, DateTime packageDate, DateTime expirationDate)
            : base(itemID, itemTitle, itemDescription, price)
        {
            _packageDate = packageDate;
            ExpirationDate = expirationDate;
            _category = category;
            _sold = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("************ Grocery Information ************");
            base.PrintInfo();    //in base class(ShoppingItem)
            System.Console.WriteLine("Package Date: " + _packageDate);
            System.Console.WriteLine("Expiration Date: " + ExpirationDate);
            System.Console.WriteLine("Category: " + _category);
        }
    }
}
