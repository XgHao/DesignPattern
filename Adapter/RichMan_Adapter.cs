using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 该适配器同时继承RichMan, IPeople
    /// </summary>
    public class RichMan_Adapter : RichMan, IPeople
    {
        public void Clothing()
        {
            //调用RichMan中对应的方法
            base.Yi();  //可简化base
        }

        public void Food()
        {
            Shi();
        }

        public void House()
        {
            Zhu();
        }

        public void Walk()
        {
            Xing();
        }
    }
}
