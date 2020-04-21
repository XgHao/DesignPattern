using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class LogDecorator : Animal
    {
        private readonly Animal animal = null;
        public LogDecorator(Animal _animal)
        {
            animal = _animal;
        }

        public override void Sound()
        {
            animal.Sound();
            //发声后，我们写入日志
            Console.WriteLine("成功写入了日志");
        }
    }
}
