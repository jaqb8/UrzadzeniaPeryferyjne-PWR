using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Position
    {
        public int Degree { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public string Type { get; set; }

        public double CoordsToOneValue
        {
            get
            {
                return Degree + (Minutes / (double)60) + (Seconds / (double)3600);
            }
        }

        override public string ToString()
        {
            return Degree + "° " + Minutes + "'" + Seconds + "\"" + Type;
        }
    }
}
