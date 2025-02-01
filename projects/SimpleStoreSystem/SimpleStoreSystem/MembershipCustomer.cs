using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class MembershipCustomer : Customer
    {
        public string _membershipNum;
        public decimal _membershipFee;
        public decimal _discountRate = 5m; //5%
        public int MAX_SHOPPING_ITEMS_BOUGHT_MEMBER = 10;
        public MembershipCustomer()
        {
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT_MEMBER];
            _discountRate = 5m; //5%
        }

        public MembershipCustomer(string customerID, string membershipNum, decimal membershipFee, string firstName, string lastName, string address, string customerSSN)
            : base(customerID, firstName, lastName, address, customerSSN)
        {
            _membershipNum = membershipNum;
            _membershipFee = membershipFee;
            _noshoppingItems = 0;
            _shopItems = new ShoppingItem[MAX_SHOPPING_ITEMS_BOUGHT_MEMBER];
            _totalPrice = 0;
        }

        public override void BuysAnItem(ShoppingItem shopItems)
        {
            decimal discountAmount = 0;

            if (_noshoppingItems > MAX_SHOPPING_ITEMS_BOUGHT_MEMBER)
            {
                System.Console.WriteLine("*********You have exceeded your maximum limit.");
            }
            else if (_totalPrice + shopItems.Price > 6000)
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
                        discountAmount = shopItems.Price * (_discountRate / 100); //gets discounted price
                        _totalPrice += (shopItems.Price - discountAmount) - 100; //gets $100 off item over $500
                    }
                    else
                    {
                        shopItems._sold = true;
                        _shopItems[_noshoppingItems] = shopItems;
                        _noshoppingItems++;
                        discountAmount = shopItems.Price * (_discountRate / 100); //gets discounted price
                        _totalPrice += shopItems.Price - discountAmount;
                    }
                    

                }
            }
        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("************ Membership Customer Information ************");
            base.PrintInfo();
            System.Console.WriteLine("Membership Number ID: " + _membershipNum);
            System.Console.WriteLine("Membership Fee: " + _membershipFee);
        }
    }
}
