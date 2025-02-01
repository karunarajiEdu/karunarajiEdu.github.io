using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Inventory inventory = new Inventory();
            StoreOwner owner = new StoreOwner("John", "Doe", "123 Main St", "111-111-1111");
            FurnitureItem furnitureItem1 = new FurnitureItem(1, "Sofa", "Reclining one", 800m, 6m, 3m, 2m, 40);
            FurnitureItem furnitureItem2 = new FurnitureItem(2, "Chair", "Non Reclining beige color", 50m, 1m, 1m, 1m, 10);
            FurnitureItem furnitureItem3 = new FurnitureItem(3, "Dinning Table", "Nice and Strong", 3000m, 8m, 2m, 1m, 200);
            FurnitureItem furnitureItem4 = new FurnitureItem(4, "Bed", "Cool and Comfy", 1100m, 8m, 2m, 1m, 100);
            FurnitureItem furnitureItem5 = new FurnitureItem(34, "Very Costly Item", "Just for Demo", 9900, 1, 1, 1, 1);
            FurnitureItem furnitureItem500Plus = new FurnitureItem(345, "500+", "500 Plus", 501, 1, 1, 1, 1);
            //owner.AddsAnItem(furnitureItem1, inventory);
            //owner.AddsAnItem(furnitureItem2, inventory);
            //owner.AddsAnItem(furnitureItem3, inventory);
            //owner.AddsAnItem(furnitureItem4, inventory);
            //owner.AddsAnItem(furnitureItem5, inventory);
            //owner.AddsAnItem(furnitureItem500Plus, inventory);
            GroceryItem groceryItem1 = new GroceryItem(5, "Bulk apples", "Too many apples", 5m, GroceryCategory.Fruit, DateTime.Today, DateTime.Today.AddDays(14));
            GroceryItem groceryItem2 = new GroceryItem(6, "Meat", "Too much meat", 15m, GroceryCategory.Fruit, DateTime.Today, DateTime.Today.AddDays(10));
            BookItem book1 = new BookItem(7, "A Good Programming Book", "A very good book", 500m, "1-1-11-1111", "Karen S", BookType.NonFiction);
            BookItem book2 = new BookItem(8, "An Excellent English Grammer Book", "A very good but costly grammar book", 1000m, "2-2-22-2222", "John Doe", BookType.NonFiction);

            //owner.AddsAnItem(groceryItem1, inventory);
            //owner.AddsAnItem(groceryItem2, inventory);
            //owner.AddsAnItem(book1, inventory);
            //owner.AddsAnItem(book2, inventory);

            //System.Console.WriteLine("Printing inventory for sanity check");
            //inventory.PrintInventoryInfo();

            inventory._shopItems.Add(furnitureItem1);
            inventory._shopItems.Add(furnitureItem2);
            inventory._shopItems.Add(furnitureItem3);
            inventory._shopItems.Add(furnitureItem4);
            inventory._shopItems.Add(furnitureItem5);
            inventory._shopItems.Add(furnitureItem500Plus);
            inventory._shopItems.Add(groceryItem1);
            inventory._shopItems.Add(groceryItem2);
            inventory._shopItems.Add(book1);
            inventory._shopItems.Add(book2);

            //1. Find all the furniture items in the inventory. (Hint: Use is operator)
            System.Console.WriteLine("*******Query 1: furniture items********");
            var furnitureItemList = inventory._shopItems.Where(x => x is FurnitureItem).Select(y => y._itemTitle).ToList();
            foreach (var s in furnitureItemList)
            {
                System.Console.WriteLine(s);
            }

            //2. Find all the items in the inventory that are priced less than 50$.
            System.Console.WriteLine("*******Query 2: items less than $50********");
            var lessThan50 = inventory._shopItems.Where(x => x._price < 50).Select(y => y._itemTitle + ' ' + y._price).ToList();
            foreach (var s in lessThan50)
            {
                System.Console.WriteLine(s);
            }

            //3. Final all the grocery items that are priced less than 10$.
            System.Console.WriteLine("*******Query 3: items less than $10********");
            var lessThan10 = inventory._shopItems.Where(x => x._price < 10 && x is GroceryItem).Select(y => y._itemTitle + ' ' + y._price).ToList();
            foreach (var s in lessThan10)
            {
                System.Console.WriteLine(s);
            }

            //4. Find all the books in the inventory whose author is "John Doe".  (Hint: x.Author won't be available, cast x to book)
            System.Console.WriteLine("*******Query 4: books with author John Doe********");
            //var bookList = inventory._shopItems.Where(x => x is BookItem).ToList();
            var bookList = inventory._shopItems.Where(x => x is BookItem && (x as BookItem)._author.Equals("John Doe")).Select(y => y._itemTitle).ToList();
            foreach (var s in bookList)
            {
                System.Console.WriteLine(s);
            }

            //5. Sort the shop items in descending order by price.
            System.Console.WriteLine("*******Query 5: items sorted by desc price********");
            var sortedByPrice = inventory._shopItems.OrderByDescending(x => x._price).Select(y => y._itemTitle + ' ' + y._price).ToList();
            foreach (var s in sortedByPrice)
            {
                System.Console.WriteLine(s);
            }

            //6. Find and sort all the books in ascending order by the title.
            System.Console.WriteLine("*******Query 6: books sorted by asc title********");
            var sortedByBookTitle = inventory._shopItems.OrderBy(z => z._itemTitle).Where(x => x is BookItem).Select(y => y._itemTitle).ToList();
            foreach (var s in sortedByBookTitle)
            {
                System.Console.WriteLine(s);
            }

            //7. Find the costliest item in the inventory. 
            System.Console.WriteLine("*******Query 7: costliest item********");
            decimal highCost = inventory._shopItems.Max(x => x._price);
            System.Console.WriteLine("Costliest Item Price: " + highCost);

            //8. Find the average price of grocery items.
            System.Console.WriteLine("*******Query 8: average price of grocery items********");
            decimal avgCost = inventory._shopItems.Where(y => y is GroceryItem).Average(x => x._price);
            System.Console.WriteLine("Average Grocery Item Price: " + avgCost);

            System.Console.ReadLine();
        }
    }
}
