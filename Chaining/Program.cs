using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chaining
{
    public class Salary
    {
        private double monthlyBasicSalary;
        double daSalary = 0;
        double overTimeSalary = 0;
        double hrSalary = 0;
        double incomeTax = 0;
        double providentFund = 0;
        double totalSalary = 0;
        double hrAllowanceInPercent = 0;
        double overTimeAllownce = 0;
        double incomeTaxInPercent = 0;
        double providentFundInPercentage = 0;
        double overTimeTotalHour = 0;

        public double getMonthlyBasicSalary()
        {
            return monthlyBasicSalary;
        }
        public double getTotalsalary()
        {
            return totalSalary;
        }
        public void setMonthlyBasicSalary(double monthlyBasicSalary)
        {
            this.monthlyBasicSalary = monthlyBasicSalary;
        }
        public Salary()
        {

        }
        public Salary(double monthlyBasicSalary)
        {
            this.monthlyBasicSalary = monthlyBasicSalary;

        }
        double daAllowanceInPercent = 0;
        bool calculateDA = false;
        bool checkAddDa = false;
        public Salary addDA(double percentage)
        {
            if (this.checkAddDa == false)
            {
                this.daSalary = (this.monthlyBasicSalary * percentage / 100);
                daAllowanceInPercent = percentage;
                calculateDA = true;
                this.checkAddDa = true;
                return this;

            }
            else
            {
                throw new Exception("This is added");
            }
            
            
        }
        
        bool calculateHR = false;
        bool checkHRAdded = false;
        public Salary addHR(double percentage)
        {
            if (this.checkHRAdded == false)
            {
                this.hrSalary = (this.monthlyBasicSalary * percentage / 100);
                hrAllowanceInPercent = percentage;
                calculateHR = true;
                this.checkHRAdded = true;
                return this;

            }
            else
            {
                throw new Exception("This is added");

            }
            
        }
        bool calculateOverTime = false;
        bool checkCalculateOverTimeAddeed = false;
        public Salary addOverTimePayment(double hours, double percentage)
        {
            if (checkCalculateOverTimeAddeed == false)
            {
                this.overTimeSalary = hours * (this.monthlyBasicSalary * percentage / 100);
                overTimeAllownce = percentage;
                overTimeTotalHour = hours;
                calculateOverTime = true;
                checkCalculateOverTimeAddeed = true;
                return this;

            }
            else
            {
                throw new Exception("This is added");
            }
            
        }
        bool calculateIncomeTax = false;
        bool checkIncomeTexAddedInsalary = false;
        public Salary subIncomeTax(double percentage)
        {
            if (checkIncomeTexAddedInsalary == false && calculateDA==true && calculateHR==true &&calculateOverTime==true)
            {
                if (monthlyBasicSalary >= 5000)
                {
                    this.incomeTax = (this.monthlyBasicSalary * percentage / 100);
                    incomeTaxInPercent = percentage;
                    calculateIncomeTax = true;
                    checkIncomeTexAddedInsalary = true;
                }
                else
                {
                    incomeTaxInPercent = 0;
                    calculateIncomeTax = true;
                    checkIncomeTexAddedInsalary = true;
                }

                return this;

            }
            else
            {
                throw new Exception("Incometex is already added");
            }
            
        }
        bool calculateProvidentFund = false;
        bool checkProvidentFundIsAddedInSalary = false;
        public Salary subProfinantFund(double percentage)
        {
            if (checkProvidentFundIsAddedInSalary == false && calculateDA == true && calculateHR == true && calculateOverTime == true)
            {
                this.providentFund = (this.monthlyBasicSalary * percentage / 100);
                providentFundInPercentage = percentage;
                calculateProvidentFund = true;
                checkProvidentFundIsAddedInSalary = true;
                return this;

            }
            else
            {
                throw new Exception("Provinent fund is alrweady added");
            }
            
           
        }

        bool all_the_functions_have_been_called = false;
        public void check()
        {
            if( calculateDA==true && calculateHR==true && calculateIncomeTax==true && calculateOverTime == true && calculateProvidentFund == true)
            {
                all_the_functions_have_been_called = true;
            }
            else
            {
                all_the_functions_have_been_called = false; ;
            }
           
            
        }

        public Salary calcNetSalary()
        {
            check();
            
            if (all_the_functions_have_been_called == true)
            {
                this.totalSalary = this.getMonthlyBasicSalary() + this.daSalary + this.hrSalary + this.overTimeSalary - this.incomeTax - this.providentFund;
                return this;
            }
            else
            {
                throw new Exception("Too early to call calcNetSalary!");
            }           

          
        }

        public string getInfo()
        {
            string info = "The DA allownce is in percent " + this.daAllowanceInPercent.ToString() + "\n" + 
                          "The HR allownce is percent " + this.hrAllowanceInPercent+"\n"+ 
                          "The overtime alownce is for "+this.overTimeTotalHour+" is "+this.overTimeAllownce+"\n"+
                          "The incometax is in percent "+this.incomeTaxInPercent+"\n"+
                          "The provident fund is in percent "+this.providentFundInPercentage;
            return info;
        }

    
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            #region code 1
            //double monthlyBasicSalary = double.Parse(Console.ReadLine());
            //  Salary sal = new Salary(monthlyBasicSalary);
            //  Console.WriteLine("The monthly basic salary is "+sal.getMonthlyBasicSalary());
            //  try
            //  {
            //      sal.addDA(3.5)
            //          .addHR(10)                   
            //          .addOverTimePayment(15, 1)
            //          .addHR(12)
            //          .subIncomeTax(2)
            //          .subProfinantFund(1)
            //           .calcNetSalary();

            //      //.getTotalsalary();

            //      //sal.calcNetSalary();
            //      Console.WriteLine("Net Salary: $" + sal.getTotalsalary());

            //      Console.WriteLine(sal.getInfo());
            //  }
            //  catch(Exception ex)
            //  {
            //      Console.WriteLine("There was an error: " + ex.Message);
            //  }


            //  //Console.WriteLine(sal.Details());
            #endregion


            


            Console.ReadKey();
        }
    }

  
}

