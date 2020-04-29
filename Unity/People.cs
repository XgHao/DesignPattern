using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity
{
    public abstract class People
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 衣
        /// </summary>
        public abstract void Clothing();

        /// <summary>
        /// 食
        /// </summary>
        public abstract void Food();

        /// <summary>
        /// 住
        /// </summary>
        public abstract void House();

        /// <summary>
        /// 行
        /// </summary>
        public abstract void Walk();
    }
}
