using System;
using System.Collections.Generic;
using System.Text;

namespace Task_struct.Utils
{
    internal class User : IAccount
    {
        private string _Fullname;
        private string _Email;
        private string _PasswordChecker;
        private int _Id;
        private int _length;
        private int _password;

        public string Fullname
        {
            get => _Fullname;
            set
            {
                _Fullname = value;
            }
        }
        public int Email { get; set; }
        public int Password;
        public int Id;
        private bool pswrd;
        private int i;

        public bool PasswordChecker(string password)
        {
            bool pswrd = false;
            bool pswrd1 = false;
            bool pswrd2 = false;
            bool pswrd3 = false;

            for (i = 0; i < password.Length - 1; i++)
            {
                if (password.Length >= 8)
                {
                    pswrd = true;
                }
                else if (char.IsLower(password[i]))
                {
                    pswrd1 = true;
                }
                else if (char.IsUpper(password[i]))
                {
                    pswrd2 = true;
                }
                else if (char.IsNumber(password[i]))
                {
                    pswrd3 = true;
                }

            }

            if (pswrd == true && pswrd1 == true && pswrd2 == true && pswrd3 == true)
            {
                return true;
            }
            else
            { return false; }

        }
        public User()
        {
            Id++;
        }
        public User(string Fullname)
        {
            this.Fullname = Fullname;
            this.Email = Email;
        }
        public void Showinfo()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"FullName:{Fullname}");
            Console.WriteLine($"Email:{Email}");

        }

        public int PasswordChecker()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}



