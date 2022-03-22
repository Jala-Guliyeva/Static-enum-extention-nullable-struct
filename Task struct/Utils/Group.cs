using System;
using System.Collections.Generic;
using System.Text;

namespace Task_struct.Utils
{
    internal class Group
    {
        private string _studentLimit;
        private Student[] student;
        private int _groupNo { get; set; }
        public string StudentLimit
        {
            get => _studentLimit;

            set
            {
                if (_studentLimit.Length >= 5 && _studentLimit.Length <= 18)
                {
                    return;
                }


            }


        }
        public bool ChekGroupNo(string GroupNo)
        {
            bool groupno1 = false;
            bool groupno2 = false;
            for (int i = 0; i < GroupNo.Length - 1; i++)
            {
                if (GroupNo.Length == 5)
                {

                    if (char.IsUpper(GroupNo[1]) && char.IsUpper(GroupNo[2]))
                    {
                        groupno1 = true;
                    }
                    
                  

                    if (char.IsNumber(GroupNo[3]) && char.IsNumber(GroupNo[4]) && char.IsNumber(GroupNo[5]))
                    {
                        groupno1 = true;
                    }
                    

                }
            }
            if (groupno1 == true && groupno2 == true)
            {
                return true;
            }
            return false;
        }
        public void AddStudent(string [] student)
        {
            
        }
    }
}
