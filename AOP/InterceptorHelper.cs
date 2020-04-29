using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public class InterceptorHelper : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            //之前
            DoSomethingBefore(invocation);

            //调用
            invocation.Proceed();

            //之后
            DoSomethinfAfter(invocation);
        }

        /// <summary>
        /// 在方法执行前，做的一些事
        /// </summary>
        /// <param name="msg"></param>
        private void DoSomethingBefore(IInvocation invocation)
        {
            Console.WriteLine("在方法执行前，做的一些事");
        }

        /// <summary>
        /// 在方法执行后，做的一些事
        /// </summary>
        /// <param name="message"></param>
        private void DoSomethinfAfter(IInvocation invocation)
        {
            Console.WriteLine("在方法执行后，做的一些事");
        }
    }
}
