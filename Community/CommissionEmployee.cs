using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    public class CommissionEmployee : Employee, ICommunityMember
    {
        //CompareTo drives consistency 
        
        public double CommissionRate { get; set; }

        //This is the Paymember Method that overrides the base version
      public override double PayMember(double hoursWorked)
        {
            
            return (HourlyRate * hoursWorked) + CalculateCommission(hoursWorked);
        }
        public double CalculateCommission(double hoursWorked)
        {
            double total = (HourlyRate * hoursWorked) * CommissionRate;
            return total;
        }
    }
}
