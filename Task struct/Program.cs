using System;
using Task_struct.Utils;

namespace Task_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Show info");
            Console.WriteLine("2.  Create new group");
         

            string selection = Console.ReadLine();


            switch (selection)
            {
                case "1":
                   
                    Console.WriteLine(User.Showinfo());
                    break;

                case "2":
                   
                    Console.WriteLine(Group.ReferenceEquals);
                    break;

                default:
                    Console.WriteLine("Not found");
                    break;
            }
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2.  Get student by id");
            Console.WriteLine("3.Add student");
            Console.WriteLine("0.Quit");
            switch (selection)
            {
                case "1":

                    Console.WriteLine(Student.ReferenceEquals));
                    break;

                case "2":

                    Console.WriteLine();
                    break;

                case "3:

                    Console.WriteLine(Student.ReferenceEquals));
                    break;

                case "0"

                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }

    }
    
    interface IAccount
    {
        int PasswordChecker();
        void ShowInfo();

        
    }
   
    
    
}
