using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace UserHelper.ProcessWatcher
{
    class Watcher
    {
        public delegate void ProcessStartEventHandler(object sender, EventArrivedEventArgs e);

        public static ManagementEventWatcher CreateWatcher(ProcessStartEventHandler handler)
        {
            var q = new WqlEventQuery();
            q.EventClassName = "Win32_ProcessStartTrace";
            var w = new ManagementEventWatcher(q);
            w.EventArrived += new EventArrivedEventHandler(handler);

            return w;
        }

        /// <summary>
        /// Ukázková obsluha události 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        public void ProcessStartEventArrived(object sender, EventArrivedEventArgs e)
        {
            foreach (PropertyData pd in e.NewEvent.Properties)
            {
                if (pd.Name == "ProcessName")
                {
                    //Console.WriteLine("{0},{1},{2}", pd.Name, pd.Type, pd.Value);
                }
            }
        }
    }
}
