using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RichMan_Adapter2 : IPeople
    {
        //组合一个RichMan实例
        private readonly RichMan richMan = new RichMan();

        public void Clothing()
        {
            richMan.Yi();
        }

        public void Food()
        {
            richMan.Shi();
        }

        public void House()
        {
            richMan.Zhu();
        }

        public void Walk()
        {
            richMan.Xing();
        }
    }
}
