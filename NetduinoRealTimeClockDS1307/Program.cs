using Microsoft.SPOT;
using System.Threading;
using Toolbox.NETMF.Hardware;

namespace NetduinoRealTimeClockDS1307
{
    public class Program
    {
        public static void Main()
        {
            var ds1307 = new DS1307();
            // To set the time to DS1307 board, comment out 
            // ds1307.SetTime(Year: 2018, Month: 12, Day: 24, Hour: 20, Minute: 28, Second: 0);
            while (true)
            {
                var time = ds1307.GetTime();
                Debug.Print("Netduino Time: " + time.ToString());
                Thread.Sleep(5000);
            }
        }
    }
}

namespace System.Diagnostics
{
    public enum DebuggerBrowsableState
    {
        Collapsed,
        Never,
        RootHidden
    }
}

