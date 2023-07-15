using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch11ex3
{
    public class CommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales; // gross weekly sales       
        private decimal commissionRate; // commission percentage

        // five-parameter constructor
        public CommissionEmployee(string first, string last, string ssn,
           decimal sales, decimal rate)
        {
            // implicit call to object constructor occurs here
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            GrossSales = sales; // validate gross sales via property
            CommissionRate = rate; // validate commission rate via property
        }
        // end of five-parameter commissionemployee constructor

        //read-only property that gets commission employee's first name
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        //read-only that gets commission employee's last name 
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        // read-only property that gets commission employee's social security number

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }

        // read-only property that gets commission employee's social security number
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "GrossSales", value, "GrossSales must be >= 0");
            }
        }

        // property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate",
                       value, "CommissionRate must be > 0 and < 1");
            } // end set
        } // end property CommissionRate

        // calculate commission employee's pay
        public virtual decimal Earnings()
        {
            return CommissionRate * GrossSales;
        } // end method Earnings              

        // return string representation of CommissionEmployee object         
        public override string ToString()
        {
            return string.Format(
               "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
               "", FirstName, LastName, //made this null in order to format with the ToString Method in the baseclasscommision employee's ToString method
               "social security number", SocialSecurityNumber,
               "gross sales", GrossSales, "commission rate", CommissionRate);
        }
    }
}
