using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class QueryProxy
    {
        private static Query query = new Query();   //单例模式，保证对象只有一个
        private QueryProxy() { }    //私有化构造函数，确保单例

        public static string GetInfo()
        {
            //这里加入新需求
            Console.WriteLine("查询中，请稍候.....");

            //具体业务操作
            return query.GetData();
        }
    }
}
