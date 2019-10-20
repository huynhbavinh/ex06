using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQueue;


namespace userQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            queue user = new queue(10);
            user.Enqueue(1);
            user.Enqueue(2);
            user.Enqueue(3);
            user.Enqueue(4);
            user.Enqueue(5);
            Console.WriteLine(@"----The count at begin when user push ell");
            user.checkCount();
            //  user Dequeue 1 element 
            Console.WriteLine(@"----Dequeue-----");
            user.Dequeue();
            Console.WriteLine(@"----Check count after Dequeue----");
            /*  check count after dequeue ( the count will -1 element after Dequeue )
             *  when user Dequeue ele that ele will go out the Queue 
             */
            user.checkCount();
            //  user wanna peek in queue
            Console.WriteLine(@"----Peek----");
            user.peek();
            //  peek different than Dequeue because : when user peek the count not change;
            Console.WriteLine(@"-----Check count afete Peek-----");
            user.checkCount();
            // push 1 ele 
            user.Enqueue(6);
            user.Enqueue(7);
            user.Enqueue(8);
            user.Enqueue(9);
            Console.WriteLine(@"-----The count after Enqueue-----");
            // then check count ? is it changing ?
            user.checkCount();
        }
    }
}
