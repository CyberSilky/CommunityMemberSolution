using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community;
using static System.Console;
namespace CommunityMemberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                FirstName = "Bob",
                LastName = "Smith",
                MemberId = "123",
                HourlyRate = 23.50
            };
            WriteLine(emp1.PrintInformation() + "Pay is " + emp1.PayMember(40).ToString("C"));



            //Using the Commission Employee
            string fname;
            string lname;
            string id;
            double hRate;
            double cRate;

            Write("Enter Employee Id >> ");
            id = ReadLine();

            Write(" Enter Employee First Name >> ");
            fname = ReadLine();

            Write(" Enter Employee Last Name >> ");
            lname = ReadLine();

            Write(" Enter Employee Hourly Rate >> ");
            hRate = double.Parse(ReadLine());

            Write(" Enter Employee Commission Rate >> ");
            cRate = double.Parse(ReadLine());


            CommissionEmployee emp2 = new CommissionEmployee()
            {
                FirstName = fname,
                LastName = lname,
                MemberId = id,
                HourlyRate = hRate,
                CommissionRate = cRate
            };

            WriteLine("Commission employee info: " + emp2.PrintInformation());
            double hours = 0;
            Write("Enter hours worked >> ");
            hours = double.Parse(ReadLine());

            WriteLine(" Employee pay: " + emp2.PayMember(hours).ToString("C"));

        }
    }
}
