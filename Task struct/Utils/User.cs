﻿using System;
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
           
           

            for (i = 0; i < password.Length - 1; i++)
            {
                if (password.Length >= 8)
                {
                    pswrd = true;
                }
                else if (char.IsLower(password[i]))
                {
                    pswrd = true;
                }
                else if (char.IsUpper(password[i]))
                {
                    pswrd= true;
                }
                else if (char.IsNumber(password[i]))
                {
                    pswrd = true;
                }

            }

            if (pswrd == true && pswrd == true && pswrd== true && pswrd == true)
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
            Console.WriteLine($"Id:{Id} FullName:{Fullname} Email:{Email}");
          

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



