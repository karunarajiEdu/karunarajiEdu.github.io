using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public abstract class Customer
    {
        public string _customerID;
        public string _firstName;
        public string _lastName;
        public string _customerSSN;
        public string _address;
        public ShoppingItem[] _shopItems;
        public int _noshoppingItems;
        public decimal _totalPrice;


        public int MAX_SHOPPING_ITEMS_BOUGHT = 3;

        public Customer() 
        {
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT];
        }

        public Customer(string customerID, string firstName, string lastName, string address, string customerSSN)
        {
            _customerID = customerID;
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _customerSSN = customerSSN;
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT];
            _totalPrice = 0;
        }

        public abstract void BuysAnItem(ShoppingItem shopItems);

        //Old Customer BuysAnItem Logic
        //if (IsMaxItemsBought())
        //    {
        //        System.Console.WriteLine("*********You have exceeded your maximum limit.");
        //    }
        //    //check if the item is over price limit or over max items
        //    // IsPriceLimitReached() if this is true, print a message
        //    // and don't allow customer to buy product
        //    else if (IsPriceLimitReached())
        //    {
        //        System.Console.WriteLine("*********You have exceeded your maximum limit.");
        //    }
        //    else
        //    {
        //        //check if the item is sold or not
        //        // furniterItems._sold if this is true, print a message
        //        // and don't allow customer to buy product
        //        if (shopItems._sold)
        //        {
        //            System.Console.WriteLine("*********Cannot buy already sold item.");
        //        }
        //        else
        //        {
        //                shopItems._sold = true;
        //                _shopItems[_noshoppingItems] = shopItems;
        //                _noshoppingItems++;
        //                _totalPrice += shopItems.Price;
                    
        //        }
        //    }
        //public bool IsMaxItemsBought()
        //{
        //    return _noshoppingItems >= MAX_SHOPPING_ITEMS_BOUGHT;
        //}

        //public bool IsPriceLimitReached()
        //{
        //    return _totalPrice >= 2000;
        //}

        public virtual void PrintInfo()
        {
            System.Console.WriteLine("************ Customer Information ************");
            System.Console.WriteLine("Customer ID: " + _customerID);
            System.Console.WriteLine("Customer Full Name: " + _firstName + ' ' + _lastName);
            System.Console.WriteLine("Customer Address: " + _address);
            System.Console.WriteLine("Customer ssn: " + _customerSSN);
            System.Console.WriteLine("Customer Number of Items Bought: " + _noshoppingItems);
            System.Console.WriteLine("Customer Total Price of Items Bought: " + _totalPrice);
            System.Console.WriteLine("List of Items Bought: ");
            for (int i = 0; i < _shopItems.Length; i++)
            {
                if (_shopItems[i] != null)
                {
                    _shopItems[i].PrintInfo();
                }
            }
        }
    }
}
