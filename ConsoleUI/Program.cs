using Entity.Concretes;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.Name = "Pencil";
            product1.UnitPrice = 25;

            Console.WriteLine(product1.Id+product1.Name+product1.UnitPrice);


        }
    }
}