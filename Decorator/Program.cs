using Decorator.Decorators;
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
            //首先实现一个具体的猫
            Animal duck = new Duck
            {
                FootNum = 2,
                HaveTail = true,
                Name = "鸭子"
            };

            
            //再装饰一个日志
            duck = new LogDecorator(duck);
            //装饰一个时间戳
            duck = new TimeStampDecorator(duck);

            duck.Sound();

            Console.Read();
        }
    }
}
