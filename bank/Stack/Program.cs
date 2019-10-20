using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class myStack
    {
        private int[] space;
        private int ele;
        private int count = 0;
        static void Main(string[] args)
        {
        }
        public myStack(int number)
        {
            space = new int[number];
        }
        public void push(int item)
        {
            ele = item;
            space[count] = ele;
            count++;
        }
        public int pop()
        { // use TEMP to remember the count input before its change
            int temp = count; 
            count--;
            Console.WriteLine(space[temp - 1]);
            return space[temp - 1];
        }
        public int checkcount()
        {
            Console.WriteLine(count);
            return count;
        }
        public int peek()
        {
            Console.WriteLine(space[count - 1]);
            return space[count - 1];
        }
        public void print()
        {
            for (int i = 0; i < space.Length; i++)
            {
                Console.Write(space[i]);
            }
        }
    }
}
