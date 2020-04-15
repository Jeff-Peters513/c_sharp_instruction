using System;

namespace ch7_Classes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create some Products");
            Product p1 = new Product("Java", "Murach's Java", 57.50);
            Product p2 = new Product(".net", "Murach's .net", 58.50);

            Console.WriteLine("");
            Console.WriteLine("");

        }
    }

    class Product {
        string Code;
        string Description;
        double Price;

        public Product() {
            Code = " ";
            Description = " ";
            Price = 0.0;
        }

        public Product(string code, string desc, double price) {
            this.Code = code;
            this.Description = desc;
            this.Price = price;
        }

        public override string ToString() {
            
            //return base.ToString();

            //interpollation example - $ in front of the string and wrap variables in {}
            return $"Product: code ={Code}, desc ={Description}, price ={Price}";

        }


    }


}


