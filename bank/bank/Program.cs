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
        private int wallet;
        public BankAccount(int money)
        {
            amount = money;
            money = wallet;
        }
        public void deposit(int money)
        {
            amount += money;
        }
        public static void withDraw(int amount)
        {

        }
        public static int balance(int amount)
        { 
            return amount;
        }
        public static void Main(String[] args)
        {

        }
    }
}
