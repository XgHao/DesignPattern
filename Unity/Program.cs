using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                ID = 1,
                Name = "郑兴豪",
                PassWD = "123123"
            };

            UserProcessor processor = TransparentProxy.Create<UserProcessor>(() => { Console.WriteLine("之前的动作"); }, () => { Console.WriteLine("之后的动作"); });
            processor.RegUser(user);

            Console.Read();
        }
    }
}
