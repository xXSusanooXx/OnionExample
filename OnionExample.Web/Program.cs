using System;
using System.Linq;
using OnionExample.DAL.EF;
using OnionExample.DAL.Entities;

namespace OnionExample.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (MobileContext context = new MobileContext())
            {
                var phones = context.Phones.ToList();
                System.Console.WriteLine(phones.Count);
            }
        }
    }
}
