using System;

namespace UC2_DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_Num = r.Next(0, 2);
            string emp_Check = "";
            int f_T_WorkingHours = 8;
            int wagePerHour = 20;
            if (random_Num == 1)
            {
                emp_Check = "Present";
                Console.WriteLine("Employee is {0}", emp_Check);
                Console.WriteLine("Daily wage of employee is {0}", f_T_WorkingHours * wagePerHour);

            }
            else
            {
                emp_Check = "Absent";
                Console.WriteLine("Employee is {0}", emp_Check);
            }

        }
    }
}