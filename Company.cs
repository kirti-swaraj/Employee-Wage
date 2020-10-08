using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class Company
    {
        public string companyName;
        public int wagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalEmpWage;
        public int workingDay;

        public Dictionary<int, int> dailyWage = new Dictionary<int, int>();


         public Company(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.workingDay = 1;
        }

        public void saveDailyWage(int dailyWage)
        {

            this.dailyWage.Add(workingDay, dailyWage);
            workingDay++;

        }


        public void saveTotalWage(int totalWage)
        {
            totalEmpWage = totalWage;
        }

    }
}
