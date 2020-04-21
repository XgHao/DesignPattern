using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    /// <summary>
    /// 时间戳装饰类
    /// </summary>
    public class TimeStampDecorator : Animal    //这里使用继承
    {
        #region 这里使用组合
        private readonly Animal animal = null;
        /// <summary>
        /// 构造方法，传入一个Animal类
        /// </summary>
        /// <param name="_animal"></param>
        public TimeStampDecorator(Animal _animal)
        {
            animal = _animal;
        }
        #endregion


        /// <summary>
        /// 重写发声方法
        /// </summary>
        public override void Sound()
        {
            //在发声之前
            Console.WriteLine($"时间戳：{DateTime.Now}");

            //调用原来(即传入Anima)的发声方法
            animal.Sound();
        }
    }
}
