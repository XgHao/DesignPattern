using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public interface IUserProcessor
    {
        string Name { get; set; }

        int Age { get; set; }

        void ShowMe();
    }
}
