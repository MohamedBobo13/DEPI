﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EventData : EventArgs
    {
        public string Message { get; set; }
        public DateTime Date  { get; set; }

    }
    public class Publisher
    {
        public event Action<object, EventData> IsArived;
        public void Notify(EventData eventData)
        {
            //if(IsArived !=null)
            if(IsArived  is not null)
                IsArived(this, eventData);
            //IsArived.Invoke(message);
        }
    }
}
