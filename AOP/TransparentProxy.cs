using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    /// <summary>
    /// 透明代理
    /// </summary>
    public static class TransparentProxy
    {
        public static T Create<T>(IUserProcessor user) where T : MarshalByRefObject
        {
            //创建T实例
            T instance = user as T;
            RealProxyHelper<T> realProxy = new RealProxyHelper<T>(instance);
            //获取当前实例的透明代理GetTransparentProxy()返回object  需要一个强制转换
            T transparentProxy = realProxy.GetTransparentProxy() as T;

            return transparentProxy;
        }
    }
}
