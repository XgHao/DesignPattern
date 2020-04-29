using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    /// <summary>
    /// 这里需要同时继承MarshalByRefObject，否则无法动态生成
    /// </summary>
    public class Student : MarshalByRefObject, IUserProcessor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowMe()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"大家好，我是{Name}，我几年{Age}岁了";
        }
    }
}
