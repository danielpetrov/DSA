namespace OrderedBagRange
{
    // Write a program to read a large collection of products (name + price) and efficiently find the first 
    //20 products in the price range [a…b].
    // Test for 500 000 products and 10 000 price searches.
    // Hint: you may use OrderedBag<T> and sub-ranges.

    using System;
    using System.Linq;
    using Wintellect.PowerCollections;
    public class StartUp
    {
        public static void Main()
        {
            const int NumberOfProductsToAdd = 500000;
            const int StartingRange = 23;
            const int EndingRange = 26;

            Random rand = new Random();

            OrderedBag<Product> largeCollectionOfProducts = new OrderedBag<Product> ();

            for (int i = 0; i < NumberOfProductsToAdd; i++)
            {
                largeCollectionOfProducts.Add(new Product(rand.Next(int.MaxValue).ToString(), rand.Next(0, 100000)));
            }

            var startProduct = new Product("", StartingRange);
            var endProduct = new Product("", EndingRange);
            var searchResult = largeCollectionOfProducts.Range(startProduct, true, endProduct, true);

            var foundProducts = searchResult.Take(20).ToList();

            foreach (var product in foundProducts)
            {
                Console.WriteLine(product);
            }
        }
    }

    public class Product : IComparable<Product>
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", this.Name, this.Price);
        }
    }
}
