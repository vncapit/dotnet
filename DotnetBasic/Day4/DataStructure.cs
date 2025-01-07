namespace DotnetBasic.Day4
{
    class Product
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int Price { get; set; }

        public Product(string _name, int _price)
        {
            Name = _name;
            Price = _price;
        }
    }


    class Practice
    {
        public void Run()
        {
            // List
            var productList = new List<Product>();
            productList.Add(new Product("Product1", 100));
            productList.Add(new Product("Product2", 200));
            productList.Add(new Product("Product3", 50));
            productList.Add(new Product("Product4", 30));

            foreach (var product in productList)
            {
                Console.WriteLine($"Product: {product.Name} - Price: {product.Price}");
            }

            var priceGt50 = productList.FindAll(product =>  product.Price > 50);

            foreach (var product in priceGt50)
            {
                Console.WriteLine($"Product has price greater than 50: {product.Name} - Price: {product.Price}");
            }

            productList.Sort((a, b) =>
            {
                //if (a.Price > b.Price) return 1;
                //if (a.Price < b.Price) return -1;
                //return 0;

                return a.Price > b.Price ? 1 : -1;
            });

            foreach (var product in productList)
            {
                Console.WriteLine($"Product: {product.Name} - Price: {product.Price}");
            }

            // SortedList

            var productSortedList = new SortedList<string, Product>();
            productSortedList.Add("prod1", new Product("Product 1", 300));
            productSortedList.Add("prod2", new Product("Product 2", 300));
            productSortedList.Add("prod3", new Product("Product 3", 300));
            productSortedList.Add("prod4", new Product("Product 4", 400));

            foreach (var product in productSortedList)
            {
                Console.WriteLine($"Key: {product.Key} - Product name: {product.Value.Name} - Price: {product.Value.Price}");
            }

            var res = productSortedList.Values.ToList().FindAll(product => product.Price > 50);

            // Dictionary
            
            var productDictionary = new Dictionary<string, Product>();
            productDictionary.Add("pd1", new Product ( "PD1",50 ));
            productDictionary.Add("pd2", new Product ( "PD2",10 ));
            productDictionary.Add("pd3", new Product ( "PD3",500 ));

            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Key {product.Key} Product: {product.Value.Name} - Price: {product.Value.Price}");
            }

            // Queue: FIFO

            var productQueue = new Queue<Product>();
            productQueue.Enqueue(new Product("pd1", 10));
            productQueue.Enqueue(new Product("pd2", 10));
            productQueue.Enqueue(new Product("pd3", 10));

            Console.WriteLine("Before dequeue");
            foreach (var product in productQueue)
            {
                Console.WriteLine($"{product.Name} -- {product.Price}");
            }

            var p = productQueue.Dequeue();
            Console.WriteLine($"After dequeue {p.Name}");
            foreach (var product in productQueue)
            {
                Console.WriteLine($"{product.Name} -- {product.Price}");
            }

            // Stack: LIFO

            var productStack = new Stack<Product>();
            productStack.Push(new Product("1", 100));
            productStack.Push(new Product("2", 200));
            productStack.Push(new Product("3", 300));

            Console.WriteLine("Before pop:");
            foreach (var item in productStack)
            {
                Console.WriteLine($"{item.Name} -- {item.Price}");
            }
            p = productStack.Pop();
            Console.WriteLine("After pop once");
            foreach (var item in productStack)
            {
                Console.WriteLine($"{item.Name} -- {item.Price}");
            }
        }

    }
}