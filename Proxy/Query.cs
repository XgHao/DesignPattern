using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class Query
    {
        public string GetData()
        {
            //Console.WriteLine("正在查询，请稍候......");
            Thread.Sleep(2000); //模拟耗时
            return "查询结果";
        }
    }
}
