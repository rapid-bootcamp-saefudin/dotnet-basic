using DataTypes.CustomType;
using DataTypes.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return "Coord (" + x + ", " + y + ")";
        }
    }

    public class MainDataType
    {
        public static void Main()
        {
            TransactionBankAccount();
            //BankAccountSample();
            //SampleClass();
            //ContohEnum();
            //ContohCoord();
        }

        #region Sample Trancation BankAccount
        public static void TransactionBankAccount()
        {
            var account = new BankAccount("Apud", 1810);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(750, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(200, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                account.MakeWithdrawal(500, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MakeWithdrawal(100, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());

            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
        }
        #endregion

        #region Sample Bank Account
        public static void BankAccountSample()
        {
            var account = new BankAccount("Apud", 68000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            var account2 = new BankAccount("Saefudin", 28000);
            Console.WriteLine($"Account2 {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
            
            var account3 = new BankAccount("Muhammad", 89000);
            Console.WriteLine($"Account3 {account3.Number} was created for {account3.Owner} with {account3.Balance} initial balance.");
            
            var account4 = new BankAccount("Muhammad Saefudin", 73000);
            Console.WriteLine($"Account4 {account4.Number} was created for {account4.Owner} with {account4.Balance} initial balance.");
        }
        #endregion

        #region Contoh Class
        public static void SampleClass()
        {
            SampleClass sampleClass;

            sampleClass = new SampleClass();
            Console.WriteLine("After call contructor");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass(3, 6);
            Console.WriteLine("After call contructor with params");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());
        }
        #endregion

        #region Contoh Enum
        public static void ContohEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Days: {0}", item);
            }

            Type fieldModel = typeof(EnumFileMode);
            foreach (var item in Enum.GetNames(fieldModel))
            {
                Console.WriteLine("FieldMode : {0}", item);
            }

            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Color Red: {0}, GetName: {1}", Colors.Red, Enum.GetName(Colors.Red));

            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));

        }
        #endregion

        #region Contoh Coord
        public static void ContohCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.Write("Point 1 : " + point1);
            Console.WriteLine();

            Coords point2 = new Coords(5, 5);
            Console.Write("Point 2 : " + point2);
        }
        #endregion

        #region Contoh Data Type
        public static void ContohDataType()
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 18, 21 };
            var query = from item in source
                        where item <= limit
                        select item;

            Console.WriteLine("Query results : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query2 = from item in source
                         where item % 2 == 1
                         select item;

            Console.WriteLine("Write item with odd : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query3 = from item in source
                         where item % 2 == 0
                         select item;

            Console.WriteLine("Write item with even : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }

            var query4 = from item in source
                         where item % 3 == 0
                         select item;

            Console.WriteLine("Write item with multiple 3 : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value : " + item);
            }
        }
        #endregion
    }
    //public class DataTypes
    //{
    //}
}