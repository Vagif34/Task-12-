using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class Student : Person
    {
        private decimal _point;

        public decimal Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0)
                {
                    _point = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name"+Name +"Surname"+Surname+ "Age"+ Age);
        }
      

        public Student(string Name, string Surname, int Age,int Id, decimal Point): base( Name,Surname,Age,Id)
        {
           _point = Point;
            
        }
        public static bool operator<(Student n1,Student n2)
        {
            return n1.Point < n2.Point;
        }
        public static bool operator>(Student n1,Student n2)
        {
            return n1.Point > n2.Point;
        }
}   }
    
