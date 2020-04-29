using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Unity
{
    public class MyRealProxy<T> : RealProxy where T : MarshalByRefObject
    {
        private T target;
        public event Action beforeAction;
        public event Action afterAction;

        public MyRealProxy(T _target) : base(typeof(T))
        {
            target = _target;
        }

        public override IMessage Invoke(IMessage msg)
        {
            //定义方法调用的消息接口
            IMethodCallMessage callMessage = msg as IMethodCallMessage;

            beforeAction?.Invoke();

            object returnValue = callMessage.MethodBase.Invoke(target, callMessage.Args);

            afterAction?.Invoke();

            return new ReturnMessage(returnValue, new object[0], 0, null, callMessage);
        }
    }

    public static class TransparentProxy
    {
        public static T Create<T>(Action beforeActoin = null, Action afterAction = null) where T : MarshalByRefObject
        {
            T instance = Activator.CreateInstance<T>();
            MyRealProxy<T> realProxy = new MyRealProxy<T>(instance);
            realProxy.beforeAction += beforeActoin;
            realProxy.afterAction += afterAction;
            T transparentProxy = (T)realProxy.GetTransparentProxy();
            return transparentProxy;
        }
    }
}
