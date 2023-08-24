using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerTest();
            OwnerTest();
        }

        private static void OwnerTest()
        {
            InMemoryOwnerDal inMemoryOwnerDal = new InMemoryOwnerDal();
            foreach (var item in inMemoryOwnerDal.GetOwnerDetails())
            {
                Console.WriteLine(item.OwnerId);
            }
        }

        private static void ComputerTest()
        {
            InMemoryComputerDal inMemoryComputerDal = new InMemoryComputerDal();
            foreach (var item in inMemoryComputerDal.GetComputerDetails())
            {
                Console.WriteLine(item.ComputerName);
            }
        }
    }
}