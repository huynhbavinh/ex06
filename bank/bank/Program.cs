using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class BankAccount
    {
        private int amount;
        public BankAccount(int money)
        {
            amount = money;
        }
        public int deposit(int money)
        {
            return amount += money;
        }
        public int withDraw(int money)
        {
            return amount -= money;
        }
        public int balance()
        {
            return amount;
        }
        public static void Main(String[] args)
        {          
        }
    }
}
