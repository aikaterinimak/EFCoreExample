using System;
using System.Linq;
using EFCoreExample.Database;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDbContext context = new CustomerDbContext();
            context.Address.Add(new Address { FullAddress = "123 Kate Lane" });
            context.SaveChanges();

            Address myAddress = context.Address.FirstOrDefault(x => x.FullAddress.Contains("Kate"));
            if(myAddress != null)
                Console.WriteLine(myAddress.FullAddress);

            Console.ReadKey();
        }
    }
}
