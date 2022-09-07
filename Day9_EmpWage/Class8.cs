using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_EmpWage
{
    internal class Class8
    {
       
            
            static int FULL_DAY_HOUR = 8;
            static int PART_TIME_HOUR = 4;
            
            

            // Calculating different parameters for different companies.

            public static void computeEmpWage(String companyName, int empRatePerHr, int numOfWorkingDays, int maxHrPerMonth)
            {

                int dailyWage;
                int dailyWageFullTime = 0;
                int dailyWagePartTime = 0;
                int fullTimePresentDays = 0;
                int partTimePresentDays = 0;
                int absentDays = 0;
                int monthlyWage;
                int workingHours = 0;
                int fullHours = 0;
                int partHours = 0;


                for (int day = 1; day <= numOfWorkingDays && workingHours <= maxHrPerMonth; day++)
                {
                       Console.WriteLine("Day " + day);
                    Random random = new Random();
                    int attendance = random.Next(0,4);
                    if (attendance == 2)
                    {

                    Console.WriteLine("Employee is present for full time");
                        dailyWageFullTime = empRatePerHr * FULL_DAY_HOUR;
                        fullTimePresentDays = fullTimePresentDays + 1;
                        fullHours += 8;
                    Console.WriteLine("Daily wage is: " + dailyWageFullTime);

                    }
                    else if (attendance == 1)
                    {
                    Console.WriteLine("Employee is present for part time.");
                        dailyWagePartTime = empRatePerHr * PART_TIME_HOUR;
                        partTimePresentDays = partTimePresentDays + 1;
                        partHours += 4;
                    Console.WriteLine("Daily wage is: " + dailyWagePartTime);

                    }
                    else
                    {
                    Console.WriteLine("Employee is absent");
                        dailyWage = 0;
                        absentDays += 1;
                        
                    Console.WriteLine("Daily wage is: " + dailyWage);
                    }
                    workingHours = fullHours + partHours;
                }
                monthlyWage = (fullTimePresentDays * dailyWageFullTime + partTimePresentDays * dailyWagePartTime);
                 Console.WriteLine("Total working hours: " + workingHours);
                 Console.WriteLine("Full Present days: " + fullTimePresentDays + "  " + "Part time Present days: " + partTimePresentDays + "  " + "Absent days: " + absentDays);
                Console.WriteLine("Total Emp wage for company " + companyName + " is " + monthlyWage);

            }


    }
   
}
