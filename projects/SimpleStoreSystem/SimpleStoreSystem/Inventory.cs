using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class Inventory
    {
        //public ShoppingItem[] _shopItems;
        public List<ShoppingItem> _shopItems;
        public int _currentItemCount;
        public int MAX_ITEM_CAPACITY = 100;

        public Inventory() 
        {
            _currentItemCount = 0;
            _shopItems = new List<ShoppingItem>(MAX_ITEM_CAPACITY);
        }

        public Inventory(int storeCapacity)
        {
            _currentItemCount = 0;
            _shopItems = new List<ShoppingItem>(MAX_ITEM_CAPACITY);
        }

        public void PrintInventoryInfo()
        {
            System.Console.WriteLine("*********** Inventory Items List: *************");
            foreach (var shopItem in _shopItems)
            {
                if (shopItem != null)
                {
                    shopItem.PrintInfo();
                }
            }
        }
    }
}
