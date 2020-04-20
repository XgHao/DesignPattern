using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Student : IPeople
    {
        public void Clothing()
        {
            Console.WriteLine("穿校服");
        }

        public void Food()
        {
            Console.WriteLine("吃食堂");
        }

        public void House()
        {
            Console.WriteLine("住宿舍");
        }

        public void Walk()
        {
            Console.WriteLine("步行");
        }
    }
}
