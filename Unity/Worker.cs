using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity
{
    class Worker : People
    {
        public override void Clothing()
        {
            Console.WriteLine("穿工作服");
        }

        public override void Food()
        {
            Console.WriteLine("吃外卖");
        }

        public override void House()
        {
            Console.WriteLine("睡宿舍");
        }

        public override void Walk()
        {
            Console.WriteLine("骑车");
        }
    }
}
