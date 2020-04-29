using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserProcessor student = new Student
            {
                Age = 22,
                Name = "zxh"
            };

            InterceptorHelper interceptor = new InterceptorHelper();
            IUserProcessor worker = new ProxyGenerator().CreateClassProxy<IUserProcessor>(interceptor);

            worker.ShowMe();

            Console.Read();



            //student.ShowMe();
            //Console.WriteLine("***************************");


            //IUserProcessor newStudent = TransparentProxy.Create<Student>(student);
            //newStudent.ShowMe();

        }
    }
}
