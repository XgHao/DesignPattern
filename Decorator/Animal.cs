using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 动物抽象类
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 腿的数量
        /// </summary>
        public int FootNum { get; set; }
        /// <summary>
        /// 有无尾巴
        /// </summary>
        public bool HaveTail { get; set; }


        /// <summary>
        /// 发声
        /// </summary>
        public abstract void Sound();
    }
}
