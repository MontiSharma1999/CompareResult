using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareResult
{
    public class CustomStopWatch : Stopwatch
    {
        public DateTime? StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }


        public new void Start()
        {
            StartAt = DateTime.Now;

            base.Start();
        }

        public new void Stop()
        {
            EndAt = DateTime.Now;

            base.Stop();
        }           

    }
    public enum OrderType
    {
        Ascending,
        Descending,
        OrderVal
    }
}
