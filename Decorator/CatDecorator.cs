using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CatDecorator : Animal
    {
        private Animal _animal = null;

        public CatDecorator(Animal animal)
        {
            _animal = animal;
        }

        public override void Sound()
        {
            _animal.Sound();
        }
    }
}
