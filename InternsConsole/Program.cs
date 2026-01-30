using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //#region Variables

            ////int id = 101;
            ////string name = "Sam";
            ////int age = 22;
            ////double salary = 45000.50;
            ////bool isActive = true;
            ////DateTime joiningDate = DateTime.Now;
            ////var department = "IT";
            ////var phoneNumber = 9876543210;

            ////// Print each variable
            ////Console.WriteLine("ID: " + id);
            ////Console.WriteLine("Name: " + name);
            ////Console.WriteLine("Age: " + age);
            ////Console.WriteLine("Salary: " + salary);
            ////Console.WriteLine("Is Active: " + isActive);
            ////Console.WriteLine("Joining Date: " + joiningDate);
            ////Console.WriteLine("Department: " + department);
            ////Console.WriteLine("Phone Number: " + phoneNumber);

            //#endregion Variables

            //#region Methods
            ////Add(10, 5);
            ////Subtract(y: 10, x: 20);
            ////Multiply(4, 5);

            ////// Type Casting
            ////double ImplicitValue = ImplicitCasting(6);
            ////Console.WriteLine("Implicitly Casted Value (int to double): " + ImplicitValue);
            ////int ExplicitValue = ExplicitCasting(9.78);
            ////Console.WriteLine("Explicitly Casted Value (double to int): " + ExplicitValue);

            //////Operators
            ////bool isEmployeeValid = ValidateEmployee(age: 25, experience: 3, salary: 35000);
            ////Console.WriteLine("Is Employee Valid: " + isEmployeeValid);

            ////Control Statements
            ////string votingStatus = CheckVotingEligibility(age: 20);
            ////Console.WriteLine("Voting Eligibility: " + votingStatus);
            ////string workTask = GetWorkTask(day: "Tuesday");
            ////Console.WriteLine("Work Task for Tuesday: " + workTask);
            ////int attendance = CountAttendance(totalStudents: 30);
            ////int loginCount = LoginAttempts(maxAttempts: 3);
            ////ProcessAttendance();
            ////ArrayExample();
            ////ListExample();
            ////StringHandlingExample();
            ////TryCatchExample();
            //#endregion Methods

            //#region Students Class Usage
            //// First student using default constructor
            ////Student student1 = new Student();
            ////student1.Id = 1;
            ////student1.Name = "Alice";

            ////// Static value (shared)
            ////Student.CollegeName = "ZYX University";

            ////Console.WriteLine("Student 1 Details:");
            ////student1.DisplayInfo();

            ////bool isCollegeValid = Student.IsCollegeValid();
            ////Console.WriteLine("Is College Valid: " + isCollegeValid);

            ////Console.WriteLine("----------------------");

            ////// Second student using parameterized constructor
            ////Student student2 = new Student(2, "Sam");

            ////Console.WriteLine("Student 2 Details:");
            ////student2.DisplayInfo();

            ////#endregion Methods

            ////Console.ReadLine();
            //#endregion Students Class Usage

            //#region Payment Class Usage
            //Console.WriteLine("Cash Payment:");
            //Payment cash = new CashPayment();
            //cash.PaymentStarted();
            //cash.MakePayment(500);

            //Console.WriteLine("--------------------");

            //Console.WriteLine("Card Payment:");
            //Payment card = new CardPayment();
            //card.PaymentStarted();
            //card.MakePayment(1200);
            //#endregion Payment Class Usage

            //#region Interfaces Usage
            ////Console.WriteLine("Using Email Service:");
            ////INotification email = new EmailNotification();
            ////NotificationService service1 = new NotificationService(email);
            ////service1.Notify("Welcome Email");

            ////Console.WriteLine("--------------------");

            ////Console.WriteLine("Using SMS Service:");
            ////INotification sms = new SmsNotification();
            ////NotificationService service2 = new NotificationService(sms);
            ////service2.Notify("OTP Message");


            //#endregion Interfaces Usage

            #region OPPs
            //Person person = new Person("John", 25);
            //person.DisplayPerson();
            //person.Show();

            //Console.WriteLine("----------------");

            //Employee emp = new Employee(101, "IT");
            //emp.DisplayEmployee();

            //Console.WriteLine("----------------");

            //Account account = new Account(5000);
            //account.Deposit(2000);
            //account.DisplayBalance();

            Opps opps = new Person();
            opps.Speak();

            #endregion OPPs

            Console.ReadLine();
        }

        public static void Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Addition: " + result);
        }

        private static void Subtract(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Subtraction: " + result);
        }

        static void Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Multiplication: " + result);
        }

        static double ImplicitCasting(int value)
        {
            // int → double (implicit)
            double result = value;
            return result;
        }

        static int ExplicitCasting(double value)
        {
            // double → int (explicit)
            int result = (int)value;
            return result;
        }

        static bool ValidateEmployee(int age, int experience, double salary)
        {
            // Arithmetic: + -
            int totalExp = experience + 1;

            // Comparison: >= <= >
            bool isAgeValid = age >= 21 && age <= 60;

            // Logical: && ||
            bool isEligible = isAgeValid && (totalExp > 2 || salary >= 30000);

            // Assignment: +=
            salary += 5000;

            // Final decision
            return isEligible;
        }

        static string CheckVotingEligibility(int age)
        {
            if (age >= 18)
            {
                return "Eligible to Vote";
            }
            else
            {
                return "Not Eligible to Vote";
            }
        }

        static string GetWorkTask(string day)
        {
            switch (day)
            {
                case "Monday":
                    return "Team Meeting";
                case "Tuesday":
                    return "Development Work";
                case "Friday":
                    return "Weekly Report";
                default:
                    return "Regular Work";
            }
        }

        static int CountAttendance(int totalStudents)
        {
            int presentCount = 0;

            for (int i = 1; i <= totalStudents; i++)
            {
                presentCount++;

                Console.WriteLine("Student " + i + " is present.");
            }

            return presentCount;
        }
        static int LoginAttempts(int maxAttempts)
        {
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                attempts++;
                Console.WriteLine("Login attempt " + attempts);
            }

            return attempts;
        }

        static void ProcessAttendance()
        {
            for (int rollNo = 1; rollNo <= 10; rollNo++)
            {
                // Continue: Student absent
                if (rollNo == 4)
                {
                    Console.WriteLine("Roll No 4 is Absent - Skipped");
                    continue;
                }

                // Break: Teacher leaves class
                if (rollNo == 8)
                {
                    Console.WriteLine("Teacher left at Roll No 8 - Stopping attendance");
                    break;
                }

                Console.WriteLine("Attendance marked for Roll No " + rollNo);
            }
        }
        static void ArrayExample()
        {
            int[] scores = { 60, 70, 80, 90 };

            Console.WriteLine("Array values:");

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("Total items in Array: " + scores.Length);
        }
        static void ListExample()
        {
            List<string> employees = new List<string>();

            // Add
            employees.Add("Alex");
            employees.Add("John");
            employees.Add("Sara");

            // Remove
            employees.Remove("John");

            Console.WriteLine("List values:");

            foreach (string emp in employees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("Total items in List: " + employees.Count);
        }

        static void StringHandlingExample()
        {
            string rawUsername = "  user123  ";
            string email = "USER@DOMAIN.COM";
            string message = "Please mark this as urgent";
            string roles = "Admin,User,Tester";
            string cardNumber = "1111222233334444";
            string password = "password123";

            // Trim & validation
            string username = rawUsername.Trim();
            Console.WriteLine("Username valid: " + !string.IsNullOrEmpty(username));

            // Case handling
            Console.WriteLine("Normalized Email: " + email.ToLower());

            // Contains
            Console.WriteLine("Contains 'urgent': " + message.Contains("urgent"));

            // Split
            string[] roleList = roles.Split(',');
            Console.WriteLine("Roles:");
            foreach (string role in roleList)
            {
                Console.WriteLine(role);
            }

            // Replace (masking)
            string maskedCard = cardNumber.Replace(cardNumber.Substring(0, 12), "************");
            Console.WriteLine("Masked Card: " + maskedCard);

            // Length check
            Console.WriteLine("Password length valid: " + (password.Length >= 8));

            // String interpolation
            Console.WriteLine($"Welcome {username}, access granted");
        }

        static void TryCatchExample()
        {
            Console.Write("Enter age: ");
            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine("Valid age entered: " + age);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Numbers only.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occurred.");
            }
        }



    }
}
