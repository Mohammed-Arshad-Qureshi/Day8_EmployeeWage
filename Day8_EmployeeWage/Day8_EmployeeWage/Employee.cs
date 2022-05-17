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
            int Daily_Wage = 0, Count_WorkingHrs = 0;
            int WorkingHrs = 0, workingDays = 20, days;
            for (days = 0; days <= workingDays; days++)
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
                Count_WorkingHrs = Count_WorkingHrs + WorkingHrs;
            }
            Daily_Wage = Count_WorkingHrs * Wage_Per_Hr;
            Console.WriteLine("salary : " + Daily_Wage);
            Console.ReadLine();

        }
    }
}
