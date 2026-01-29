using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsConsole
{
    public  class Student
    {
        // Instance variables (per object)
        public int Id;
        public string Name;
        public decimal Marks;

        // Static variable (shared by all objects)
        public static string CollegeName;

        // Static constructor (runs once)
        static Student()
        {
            CollegeName = "ABC College";
        }

        // Default constructor
        public Student()
        {
            Id = 0;
            Name = "Not Assigned";
        }

        // Parameterized constructor
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            CollegeName = "XYZ University";
            this.Marks = 100;
        }

        // Instance method
        public void DisplayInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("College: " + CollegeName);
        }

        // Static method
        public static bool IsCollegeValid()
        {
            return !string.IsNullOrEmpty(CollegeName);
        }
    }
}
