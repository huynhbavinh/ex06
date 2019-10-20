using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;


namespace userStack
{
    class uStack
    {
        static void Main(string[] args)
        {
            myStack user = new myStack(10); // space of data in stack;
            user.push(1);
            user.push(2);
            user.push(3);
            user.push(4);
            /*Console.WriteLine(@"-----Peek lasted element and the element still stay in stack");
            user.peek();
            user.checkcount(); */
            Console.WriteLine(@"-----Pop lasted element and that element go out the stack");
            user.pop();
            user.checkcount();
            /* the count will count down when every time pop */
            Console.WriteLine(@"----Pop againt");
            user.pop();
            user.checkcount();
        }
    }
}
