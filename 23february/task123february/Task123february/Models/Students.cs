using System;
using System.Collections.Generic;
using System.Text;

namespace Task123february

{
    class Students
    {
        private string _fullname;
        public string FullName
        {
            get { return _fullname; }
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("duzgun ad soyad daxil et");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }


        private string _groupno;
        public string GroupNo
        {
            get { return _groupno; }
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun grup nomresi daxil edin");
                    value = Console.ReadLine();
                }
                _groupno = value;
            }
        }
        public int Age { get; set; }




        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                        return false;
                }
                return true;
            }
            return false;


        }


        public static bool CheckFullname(string fullname)
        {
            return fullname.Split(' ').Length >= 2;
        }
        public Students(string fullname, string groupno, int age)
        {
            FullName = fullname;
            Age = age;
            GroupNo = groupno;
        }

    }
}
