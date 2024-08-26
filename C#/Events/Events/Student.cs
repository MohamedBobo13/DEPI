using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Student
    {
        public void IsArrivedStudent(object sender,EventData eventData)
        {
            if (sender is Publisher)
            {
                Console.WriteLine($"Publisher Notify Me With Message - {eventData.Message} ");
            }
            else if(sender is Web)
            {
                Console.WriteLine($"Web Notify Me With Message -{eventData.Message} " );
            }
        }
    }
}
