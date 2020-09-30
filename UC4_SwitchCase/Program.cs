using System;

namespace UC4_SwitchCase
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

            switch (random_Num)
            {
                case 1:
                    {
                        emp_Check = "Present";
                        Console.WriteLine("Employee is {0} and full time", emp_Check);
                        Console.WriteLine("Daily wage of employee is {0}", f_T_WorkingHours * wagePerHour);
                        break;
                    }
                case 2:
                    {
                        emp_Check = "Present";
                        Console.WriteLine("Employee is {0} and Part time", emp_Check);
                        Console.WriteLine("Daily wage of employee is {0}", p_T_WorkingHours * wagePerHour);
                        break;
                    }

                case 0:
                    {
                        emp_Check = "Absent";
                        Console.WriteLine("Employee is {0}", emp_Check);
                        break;
                    }
            }
        }
    }
}

        
