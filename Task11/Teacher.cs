using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class Teacher : Person
    {



        private decimal _salary;

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name" +Name+ "Surname"+Surname,"Age"+Age + "Salary"+ Salary);
        }

        public Teacher(string Name, string Surname, int Age,int Id, decimal Point): base(Name, Surname, Age, Id)
        {
            _salary = Salary;
            

        }
        public static bool operator<(Teacher v1,Teacher v2)
        {
            return v1.Salary < v2.Salary;
        }
        public static bool operator>(Teacher v1,Teacher v2)
        {
            return v1.Salary > v2.Salary;
        }













    }
}
