using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Watch
    {
        public int WatchId { get;private  set; }

        public string WatchName { get;private set; }

        public void ChangeWatchName(string watchName) 
        {
            WatchName = watchName;
        }

    }
}
