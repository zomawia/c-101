using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct DatePeriod
    {
        public void AddDays(int addedDays) { Days += addedDays; }
        public void AddWeeks(int addedWeeks) { Days += addedWeeks * 7; }
        public void AddYears(int addedYears) { Days += addedYears * 365; }

        public int Days { private set; get; }
        public int Weeks
        {
            get
            {
                if (Days >= 7)
                {
                    return Days / 7;
                }
                else return 0;
            }
            set { Weeks = value; }
        }
        public int Years
        {
            get
            {
                if (Days >= 365)
                {
                    return Days / 365;
                }
                else return 0;              
            }
            set
            {
                Years = value;
            }
        }
    }
}
