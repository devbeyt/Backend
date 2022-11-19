using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            
        }
    }
}
