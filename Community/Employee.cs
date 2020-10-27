using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    public class Employee : ICommunityMember
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string MemberId { get ; set ; }
        private double rate;
        public double HourlyRate
        {
            get { return rate; }

            set
            {
                if (value > 0)
                    rate = value;
                else
                    throw new ApplicationException("rate must be greater than 0");
            }

        }
        //virtual means the method can be overwritten 
        public virtual double PayMember(double hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        public string PrintInformation()
        {
            return $"Name is {FirstName} {LastName} and Id is {MemberId}";
        }
    }
}
