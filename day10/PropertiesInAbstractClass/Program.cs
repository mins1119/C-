using System;

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return string.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate 
        { 
            get; 
            set; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {ProductDate = new DateTime(2020,08,03)};
            Console.WriteLine($"Product : {product_1.SerialID}, Product Date : {product_1.ProductDate}");

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2020, 07, 20) };
            Console.WriteLine($"Product : {product_2.SerialID}, Product Date : {product_2.ProductDate}");
        }
    }
}
