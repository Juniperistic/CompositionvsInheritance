using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Ch11Ex3.cs                                          */
/* Date:             04/21/2022                                          */
/* Programmer:       Miranda Morris                                      */
/* Class:            CSCI 234                               		     */
/*                                                                  	 */
/* Program Description: The purpose of this program is to recreate the   */
/* commissionemployee using composition instead of inheritance to        */
/* use the same properties and methods as the original.                  */
/*                                                                       */
/* Input: employee first name, employee last name, employee ssn, gross   */
/* weekly sales, & commission percentage                                 */
/*                                                                       */
/* Output: employee first name, employee last name, employee ssn, gross  */
/* weekly sales, & commission percentage  				                 */
/*                                                                       */
/* Givens: None					                                         */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data: I ran the program                        */
/*                                                                       */
/* List the Testing Output Data: The screen came up saying "press any    */
/* key to continue"                                                      */
/*************************************************************************/

//unsure of why the program doesn't actually ask for any inputs or output anything but the program still runs
namespace ch11ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class BasePlusCommissionEmployee
        {
            //we create a private decimal named basesalary and create the public commissionemployee object that we can then use to help inherit the methods and properties from the commissionemployee class
            private decimal baseSalary;
            public CommissionEmployee commissionEmployee;

            //creating the constructor for BasePlusCommissionEmployee
            public BasePlusCommissionEmployee(string first, string last,
               string ssn, decimal sales, decimal rate, decimal salary)
            {
                commissionEmployee = new CommissionEmployee(first, last, ssn, sales, rate);
                BaseSalary = salary;
            }

            // creating the basepluscommissionemployee's base salary
            public decimal BaseSalary
            {
                get
                {
                    return baseSalary;
                }
                set
                {
                    if (value >= 0)
                        baseSalary = value;
                    else
                        throw new ArgumentOutOfRangeException("BaseSalary",
                           value, "BaseSalary must be >= 0");
                }
            }

            //now we are going to calculate the earnings
            public decimal Earnings()
            {
                return BaseSalary + commissionEmployee.Earnings();
            }
            //displays the employee's information on the screen

            //we switch from using a base.ToString to using the tostring method which is part of the commissionemployee object
            public override string ToString()
            {
                return string.Format("base-salaried employee: {0}\nbase salary: {1:C}",
                   commissionEmployee.ToString(), BaseSalary);
            }
        }
    }
}
