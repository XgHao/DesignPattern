using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public class UserProcessorDecorator : IUserProcessor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private readonly IUserProcessor user = null;

        public UserProcessorDecorator(IUserProcessor _user)
        {
            user = _user;
            Name = user.Name;
            Age = user.Age;
        }

        public void ShowMe()
        {
            Console.WriteLine("Do Something Before");
            user.ShowMe();
            Console.WriteLine("Do Something After");
        }
    }
}
