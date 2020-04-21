using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Duck : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("嘎嘎嘎");
        }
    }
}
