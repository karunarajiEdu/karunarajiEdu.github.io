using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class FurnitureItem : ShoppingItem, ICloneable //derived from ShoppingItem
    {
        public decimal _height;
        public decimal _width;
        public decimal _length;
        public decimal _weight;

        //properties for FurnitureItem
        public decimal Height
        {
            get { return _height; }
            set { 
                if(value < 0)   //check if positive
                {
                    throw new ArgumentException("Height should be positive.", "height");
                }
                _height = value; }
        }

        public decimal Width
        {
            get { return _width; }
            set
            {
                if (value < 0)   //check if positive
                {
                    throw new ArgumentException("Width should be positive.", "width");
                }
                _width = value;
            }
        }

        public decimal Length
        {
            get { return _length; }
            set
            {
                if (value < 0)   //check if positive
                {
                    throw new ArgumentException("Length should be positive.", "length");
                }
                _length = value;
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0)   //check if positive
                {
                    throw new ArgumentException("Weight should be positive.", "weight");
                }
                _weight = value;
            }
        }

        //TODO: Change item sold or not in Customer, move sold to ShoppingItem

        public FurnitureItem() { }

        public FurnitureItem(int itemID, string itemTitle, string itemDescription, decimal price, decimal length, decimal width, decimal height, decimal weight)
        : base(itemID, itemTitle, itemDescription, price){
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            _sold = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("************ Furniture Information ************");
            base.PrintInfo();    //in base class(ShoppingItem)
            System.Console.WriteLine("Item Length: " + Length);
            System.Console.WriteLine("Item Width: " + Width);
            System.Console.WriteLine("Item Height: " + Height);
            System.Console.WriteLine("Item Weight: " + Weight);
        }

    }
}
