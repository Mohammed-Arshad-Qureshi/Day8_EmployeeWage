using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_EmployeeWage
{
    class Employee
    {
        public void Calculate()
        {
            int Is_Part_Time = 2;
            int Is_Full_Time = 1;
            int Wage_Per_Hr = 20;
            int Daily_Wage = 0;
            int WorkingHrs = 0;
            Random r = new Random();
            int check = r.Next(0, 3);
            switch (check)
            {
                case 1:
                    WorkingHrs = 8;
                    break;
                case 2:
                    WorkingHrs = 4;
                    break;
                default:
                    WorkingHrs = 0;
                    break;
            }
            Daily_Wage = WorkingHrs * Wage_Per_Hr;
            Console.WriteLine(Daily_Wage);
            Console.ReadLine();
        }
    }
}
