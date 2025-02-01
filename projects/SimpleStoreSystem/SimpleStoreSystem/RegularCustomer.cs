using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class RegularCustomer : Customer
    {
        public string _regCustomerID;
        public int MAX_SHOPPING_ITEMS_BOUGHT_REGULAR = 6;
        public RegularCustomer()
        {
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT_REGULAR];
        }

        public RegularCustomer(string customerID, string regCustomerID, string firstName, string lastName, string address, string customerSSN)
            : base(customerID, firstName, lastName, address, customerSSN)
        {
            _regCustomerID = regCustomerID;
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT_REGULAR];
            _totalPrice = 0;
        }

        public override void BuysAnItem(ShoppingItem shopItems)
        {

            if (_noshoppingItems > MAX_SHOPPING_ITEMS_BOUGHT_REGULAR)
            {
                System.Console.WriteLine("*********You have exceeded your maximum limit.");
            }
            //check if the item is over price limit or over max items
            // IsPriceLimitReached() if this is true, print a message
            // and don't allow customer to buy product
            else if (_totalPrice + shopItems.Price > 3000)
            {
                System.Console.WriteLine("*********You have exceeded your maximum price limit.");
            }
            else
            {
                //check if the item is sold or not
                // furniterItems._sold if this is true, print a message
                // and don't allow customer to buy product
                if (shopItems._sold)
                {
                    System.Console.WriteLine("*********Cannot buy already sold item.");
                }
                else
                {
                    if(shopItems.Price > 500)
                    {
                        shopItems._sold = true;
                        _shopItems[_noshoppingItems] = shopItems;
                        _noshoppingItems++;
                        _totalPrice += shopItems.Price - 100; //gets $100 off item over $500
                    }
                    else
                    {
                        shopItems._sold = true;
                        _shopItems[_noshoppingItems] = shopItems;
                        _noshoppingItems++;
                        _totalPrice += shopItems.Price;
                    }
                    

                }
            }
        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("************ Regular Customer Information ************");
            base.PrintInfo();
            System.Console.WriteLine("Regular Customer ID: " + _regCustomerID);
        }

    }
}
