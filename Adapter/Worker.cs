using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Worker : IPeople
    {
        public void Clothing()
        {
            Console.WriteLine("穿工装");
        }

        public void Food()
        {
            Console.WriteLine("吃外卖");
        }

        public void House()
        {
            Console.WriteLine("住板房");
        }

        public void Walk()
        {
            Console.WriteLine("电动车");
        }
    }
}
