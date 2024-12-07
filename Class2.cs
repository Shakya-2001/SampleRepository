using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankOpen
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Typeofacc obj=new Typeofacc();
            obj.GetDetails();
            obj.Deposite();
            obj.Withdraw();
            obj.Display();
        }
    }
}
