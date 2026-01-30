using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsConsole
{
    public class Opps
    {
        protected string oppsName = "OOPs Concepts in C#";
        protected string message = "Parent";
        protected void MainOpps()
        {
            
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    public class Person: Opps
    {
        protected new string message = "Child";

        // Private fields
        private int _age;
        private string _name;

        // Public properties (getter / setter)
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }
        public Person()
        {
        }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            oppsName = "Accessing from Person Class";
            base.oppsName = "Accessing from Person Class using base";
            this.oppsName = "Accessing from Person Class using this";
        }

        // Method
        public void DisplayPerson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        public void Show()
        {
            Console.WriteLine(this.message); // Child
            Console.WriteLine(base.message); // Parent
        }

        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Employee
    {
        // Public fields (direct access – teaching purpose)
        public int EmployeeId;
        public string Department;

        // Constructor
        public Employee(int employeeId, string department)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        // Method
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id: " + EmployeeId);
            Console.WriteLine("Department: " + Department);
        }
    }

    public class Account
    {
        // Private field
        private double _balance;

        // Public property
        public double Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        // Constructor
        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        // Method
        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }
}