using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_25024WE.Models
{
    public class Coordenate
    {
        public int Node { get; set; }
        public double MHL_X { get; set; }
        public double MHL_Y { get; set; }
        public double MHL_Z { get; set; }
        public double TXT_X { get; set; }
        public double TXT_Y { get; set; }
        public double TXT_Z { get; set; }
    }

    public class TemplateCoordenates
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CharWidth { get; set; }
        public double CharHeight { get; set; }
        public double LabelAngle { get; set; }
        public double TextAngle { get; set; }
        public double CharFullWidth { get; set; }
        public List<Coordenate> Coordinates { get; set; }
    }
}
