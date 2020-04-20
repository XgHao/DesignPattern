using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPeople
    {
        /// <summary>
        /// 衣
        /// </summary>
        void Clothing();

        /// <summary>
        /// 食
        /// </summary>
        void Food();

        /// <summary>
        /// 住
        /// </summary>
        void House();

        /// <summary>
        /// 行
        /// </summary>
        void Walk();
    }
}
