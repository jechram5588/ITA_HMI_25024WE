using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_25024WE.Models
{
    public class MarkingParameters
    {
        public double LaserPower { get; set; }
        public int ScanSpeed { get; set; }
        public int Frequency { get; set; }
        public int SpotVariable { get; set; }
        public int Repetition { get; set; }
        public double FillLineInterval { get; set; }
    }
}
