using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public enum BookType    //aka Genre
    {
        NonFiction = 1,
        Mystery = 2,
        Thriller = 3,
        SelfHelp = 4,
        SciFi = 5
    }
    public class BookItem : ShoppingItem, ICloneable    //derived from ShoppingItem
    {
        public string _ISBNnum;
        public string _author;
        public BookType _bookType;

        public BookItem() { }

        public BookItem(int itemID, string itemTitle, string itemDescription, decimal price, string ISBNnum, string author, BookType bookType)
            : base(itemID, itemTitle, itemDescription, price)
        {
            _ISBNnum = ISBNnum;
            _author = author;
            _bookType = bookType;
            _sold = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("************ Book Information ************");
            base.PrintInfo();    //in base class(ShoppingItem)
            System.Console.WriteLine("ISBN Number: " + _ISBNnum);
            System.Console.WriteLine("Author: " + _author);
            System.Console.WriteLine("Genre/Book Type: " + _bookType);
        }
    }
}
