using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public class RealProxyHelper<T> : RealProxy where T : MarshalByRefObject
    {
        /// <summary>
        /// 保存对象字段
        /// </summary>
        private readonly T target;

        /// <summary>
        /// 构造函数，需要调用父类构造方法
        /// </summary>
        /// <param name="_target"></param>
        public RealProxyHelper(T _target) : base(typeof(T))
        {
            target = _target;
        }

        /// <summary>
        /// 在方法执行前，做的一些事
        /// </summary>
        /// <param name="msg"></param>
        private void DoSomethingBefore(IMessage message)
        {
            Console.WriteLine("在方法执行前，做的一些事");
        }

        /// <summary>
        /// 在方法执行后，做的一些事
        /// </summary>
        /// <param name="message"></param>
        private void DoSomethinfAfter(IMessage message)
        {
            Console.WriteLine("在方法执行后，做的一些事");
        }


        /// <summary>
        /// 这里是要调用的方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public override IMessage Invoke(IMessage msg)
        {
            //之前
            DoSomethingBefore(msg);

            //调用方法接口
            IMethodCallMessage callMessage = msg as IMethodCallMessage;

            //callMessage.MethodBase.Invoke 执行调用方法
            //target 对象
            //callMessage.Args 方法的参数数组
            //returnValue 方法的返回值
            object returnValue = callMessage.MethodBase.Invoke(target, callMessage.Args);

            //之后
            DoSomethinfAfter(msg);

            //返回调用方法的结果
            /* 参数:
               ret:
                 从中生成当前 System.Runtime.Remoting.Messaging.ReturnMessage 实例的被调用方法所返回的对象。
               outArgs:
                 作为 out 参数从被调用方法返回的对象。
               outArgsCount:
                 从被调用方法返回的 out 参数的数目。
               callCtx:
                 方法调用的 System.Runtime.Remoting.Messaging.LogicalCallContext。
               mcm:
                 对被调用方法进行的原始方法调用。
            */
            return new ReturnMessage(returnValue, Array.Empty<object>(), 0, null, callMessage);
        }

    }
}
