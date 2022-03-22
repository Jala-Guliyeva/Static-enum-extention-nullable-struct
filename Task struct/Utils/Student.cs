using System;
using System.Collections.Generic;
using System.Text;

namespace Task_struct.Utils
{
    internal class Student
    {
        public int Id { get; }
        public string FullName { get; set; }
        public double Point { get; set; }

        public Student(string fullname,double point)
        {
            this.FullName = fullname;
            this.Point= point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"FullName{FullName}");
            Console.WriteLine($"Point:{Point}");
        }
        public Student()
        {
            Id++;
        }
    }
}
