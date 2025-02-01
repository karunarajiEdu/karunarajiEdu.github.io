using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class StoreOwner
    {
        public string _firstName;
        public string _lastName;
        public string _address;
        public string _ownerSSN;

        public StoreOwner() { }

        public StoreOwner(string firstName, string lastName, string address, string ownerSSN)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _ownerSSN = ownerSSN;
        }

        public void AddsAnItem(ShoppingItem item, Inventory inventory)
        {
            //if store owner calls AddsAnItem, this is store owner
            item._owner = this;
            // initial current item count = 0
            inventory._shopItems.Add(item);
            // increment current item count
            //inventory._currentItemCount++;
        }

        public void PrintOwnerInfo()
        {
            System.Console.WriteLine("********* Store Owner Info: ************");
            System.Console.WriteLine("Store Owner Name: " + _firstName + ' ' + _lastName);
            System.Console.WriteLine("Store Owner address: " + _address);
            System.Console.WriteLine("Store Owner ssn: " + _ownerSSN);
        }
    }
}
