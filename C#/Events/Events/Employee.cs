using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Employee
    {
        public void IsArrivedEmployee(object sender,EventData eventData)
        {
            Console.WriteLine($"notified  {eventData.Message} ");
        }
    }
}
