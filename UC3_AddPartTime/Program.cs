using System;

namespace UC3_AddPartTime
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
            if (random_Num == 1)
            {
                emp_Check = "Present";
                Console.WriteLine("Employee is {0}", emp_Check);
                Console.WriteLine("Employee is {0} and full time", emp_Check);
                Console.WriteLine("Daily wage of employee is {0}", f_T_WorkingHours * wagePerHour);

            }
            else if (random_Num == 2)
            {
                emp_Check = "Present";
                Console.WriteLine("Employee is {0} and Part time", emp_Check);
                Console.WriteLine("Daily wage of employee is {0}", p_T_WorkingHours * wagePerHour);
            }
            else
            {
                emp_Check = "Absent";
                Console.WriteLine("Employee is {0}", emp_Check);
            }

        }
    }
}