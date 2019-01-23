using Microsoft.SPOT;
using NetMf.CommonExtensions;
using System.Threading;
using Toolbox.NETMF.Hardware;

namespace NetduinoRealTimeClockDS1307
{
    public class Program
    {
        public static void Main()
        {
            var ds1307 = new DS1307();
            //Uncomment the following line to set the time to DS1307 board
            //ds1307.SetTime(Year: 2018, Month: 01, Day: 23, Hour: 16, Minute: 59, Second: 0);
            while (true)
            {
                var time = ds1307.GetTime();
                var formattedDate = StringUtility.Format(
                    "Netduino Time in UTC: {0}",
                    time.ToString("yyyy-MM-ddTHH:mm:ssZ")
                );
                Debug.Print(formattedDate);

                //sleep for 5 seconds
                Thread.Sleep(5000);
            }
        }
    }
}

