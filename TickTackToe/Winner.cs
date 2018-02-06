using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TickTackToe
{
    public class Winner 
    {
        [XmlElement("Name")]
        public string name { get; set; }
        [XmlElement("OpponentName")]
        public string opponentName { get; set; }
        [XmlElement("SizeOfMap")]
        public int sizeOfMap { get; set; }
        [XmlElement("SizeOfwin")]
        public int sizeOfWin { get; set; }

        Winner() { }

        public Winner(string n, string on, int sm, int sw)
        {
            this.name = n;
            this.opponentName = on;
            this.sizeOfMap = sm;
            this.sizeOfWin = sw;
        }

        public override string ToString()
        {
            return name + " " + sizeOfMap + " " + sizeOfWin;
        }
    }
}
