using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Student
    {
        private Student()
        {
            Console.WriteLine("调用了一次构造函数");
        }

        static Student()
        {
            student = new Student();
        }

        private static volatile Student student = null;

        private static object Singleton_Lock = new object();
        public static Student CreateInstance()
        {
            //如果student == null 则返回new Student()
            if (student == null)
            {
                lock (Singleton_Lock)
                {
                    if (student == null)
                    {
                        student = new Student();
                    }
                }
            }

            return student;
        }
    }
}
