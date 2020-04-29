using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public class Worker : IUserProcessor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowMe()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"大家好，我是{Name}，我几年{Age}岁了";
        }
    }
}
