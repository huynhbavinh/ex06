using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank;

namespace UserBank
{
    class User
    {
        static void Main(string[] args)
        {

            Console.WriteLine("money u want in your wallet when u created ur account");
            int wallet = Convert.ToInt32(Console.ReadLine());
            BankAccount user1 = new BankAccount(wallet);
            Console.WriteLine("wallet : {0}", user1.balance());
            Console.WriteLine("What service u want to chose => 1: for Deposit // 2: for WithDraw");
            int chose = Convert.ToInt32(Console.ReadLine());
            if (UserChose(chose))
            {
                Console.WriteLine("Money u want put in : ");
                int moneyIn = Convert.ToInt32(Console.ReadLine());
                user1.deposit(moneyIn);
            }
            else
            {
                Console.WriteLine("Money u want WithDraw : ");
                int moneyOut = Convert.ToInt32(Console.ReadLine());
                user1.withDraw(moneyOut);
            }
            Console.WriteLine("ur Wallet after service : {0}", user1.balance());
        }
        static bool UserChose(int chose) // hàm dùng chung(tĩnh, Thay đổi giá trị không ảnh hưởng)
        {
            if (chose == 1)
            {
                return true;
            }
            return false;
        }
    }
}
