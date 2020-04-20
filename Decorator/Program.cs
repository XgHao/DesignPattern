using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal cat = new Cat
            {
                FootNum = 4,
                HaveTail = true,
                Name = "猫"
            };

            //CatDecorator catDecorator = new CatDecorator(cat);
            //Animal catDecorator = new CatDecorator(cat);
            cat = new CatDecorator(cat);
        }
    }
}
