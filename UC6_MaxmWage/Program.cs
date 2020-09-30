﻿using System;

namespace UC6_MaxmWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_Num = r.Next(0, 3);
            string emp_Check = "";
            int f_T_WorkingHours = 8;
            int p_T_WorkingHours = 4;
            int wagePerHour = 20;
            int work_Days_In_Month = 20;
            int total_Emp_Work_Hours = 0;

            int monthly_Wage;


            switch (random_Num)
            {
                case 1:
                    emp_Check = "Present";
                    Console.WriteLine("Employee is {0} and full time", emp_Check);
                    Console.WriteLine("Daily wage of employee is {0}", f_T_WorkingHours * wagePerHour);
                    break;

                case 2:
                    emp_Check = "Present";
                    Console.WriteLine("Employee is {0} and Part time", emp_Check);
                    Console.WriteLine("Daily wage of employee is {0}", p_T_WorkingHours * wagePerHour);
                    break;
                case 0:
                    emp_Check = "Absent";
                    Console.WriteLine("Employee is {0}", emp_Check);
                    break;
            }
            for (int i = 1; i <= work_Days_In_Month; i++)
            {
                switch (r.Next(0, 3))
                {
                    case 1:
                        total_Emp_Work_Hours += 8;//emp present for full day on that working day
                        break;
                    case 2:
                        total_Emp_Work_Hours += 4; //emp present for part time on that working day
                        break;
                    case 0:
                        break;
                }
            }

            Console.WriteLine("Maximum no of working hours to be considered is 100");
            Console.WriteLine("No of working hours of employee in a month are {0}", total_Emp_Work_Hours);
            monthly_Wage = total_Emp_Work_Hours * 20;
            if (total_Emp_Work_Hours <= 100)
                monthly_Wage = total_Emp_Work_Hours * 20;
            else
                monthly_Wage = 100 * 20;

            Console.WriteLine("Montly wage of employee is {0}", monthly_Wage);
        }
    }
}