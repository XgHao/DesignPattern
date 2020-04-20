using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintfInfo(new Student());
            PrintfInfo(new Worker());
            PrintfInfo(new RichMan_Adapter());

            Console.Read();
        }

        public static void PrintfInfo(IPeople people)
        {
            people.Clothing();
            people.Food();
            people.House();
            people.Walk();
            Console.WriteLine("********分割线*********");
        }
    }
}
