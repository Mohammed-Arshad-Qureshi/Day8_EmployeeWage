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

            int Wage_Per_Hr = 20;
            int Daily_Wage = 0;
            int WorkingHrs = 0, WorkingDays = 20, days = 0, Total_Hrs = 0;
            while (days <= WorkingDays && Total_Hrs <= 100)
            {
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
                days++;
                Total_Hrs = Total_Hrs + WorkingHrs;
            }
            Daily_Wage = Total_Hrs * Wage_Per_Hr;
            Console.WriteLine("salary : " + Daily_Wage);
            Console.ReadLine();

        }
    }
}
