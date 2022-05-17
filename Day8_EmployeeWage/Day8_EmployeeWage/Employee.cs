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
            int Is_Present = 1;
            int Wage_Per_Hr = 20;
            int Daily_Wage = 0;
            int WorkingHrs = 0;
            Random r = new Random();
            int check = r.Next(0, 2);
            if (Is_Present == check)
                WorkingHrs = 8;
            else
                WorkingHrs = 0;
            Daily_Wage = WorkingHrs + Wage_Per_Hr;
            Console.WriteLine(Daily_Wage);
            Console.ReadLine();
        }
    }
}
