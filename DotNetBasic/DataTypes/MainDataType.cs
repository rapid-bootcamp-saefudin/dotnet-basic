using DataTypes.CustomType;
using DataTypes.InheritanceType;
using DataTypes.ObjectType;
using DataTypes.OOP;
using DataTypes.PolymorphismType;
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
            SamplePolymorphism();
            //SampleInheritance();
            //SampleObject();
            //MonthlyDeposit();
            //TransactionBankAccount();
            //BankAccountSample();
            //SampleClass();
            //ContohEnum();
            //ContohCoord();
        }

        #region Sample Polymorphism
        public static void SamplePolymorphism()
        {
            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used wherever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var shapes = new List<Shape>
            {
                new PersegiPanjang(),
                new Segitiga(),
                new Lingkaran()
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            /* Output:
                Drawing a rectangle
                Performing base class drawing tasks
                Drawing a triangle
                Performing base class drawing tasks
                Drawing a circle
                Performing base class drawing tasks
            */
        }
        #endregion

        #region Sample Inheritance
        public static void SampleInheritance()
        {
            // Create an instance of WorkItem by using the constructor in the
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                        "Fix all bugs in my code branch",
                                        new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                    "Add members to the class",
                                                    new TimeSpan(4, 0, 0),
                                                    1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());
        }

        #endregion

        #region Sample Object
        public static void SampleObject()
        {
            Person person = new Person("Kayla", 24);
            Console.WriteLine("person Name = {0} Age = {1}", person.Name, person.Age);

            Person person2 = person;

            person2.Name = "Apud";
            person2.Age = 22;

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person Name = {0} Age = {1}", person.Name, person.Age);

            Person person3 = new Person("Saefudin", 25);
            Console.WriteLine("person3 Name = {0} Age = {1}", person3.Name, person3.Age);
        }
        #endregion

        #region Monthly Deposit
        public static void MonthlyDeposit()
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
        #endregion

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