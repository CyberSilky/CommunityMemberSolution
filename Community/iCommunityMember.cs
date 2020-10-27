using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    interface ICommunityMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MemberId { get; set; }

        double HourlyRate { get; set; }

        string PrintInformation();

        double PayMember(double hoursWorked);

    }
}
