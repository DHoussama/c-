using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ex
{
    [XmlRoot("Jedi")]
    public class Jedi
    {
        
        private string Name;
       
        private int MidiChlorianCount;

        public Jedi() { }
        public Jedi(string a,int b)
        {
            Name = a;
            MidiChlorianCount = b;
        }

        [XmlAttribute("essmi")]
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        [XmlAttribute("numero")]
        public int midiChlorianCount
        {
            get { return MidiChlorianCount; }
            set {
                if (value <= 0)
                    throw new ArgumentException("You are not a true Jedi!");
                else
                    MidiChlorianCount = value;
            
            
            
               }
        }
        public override string ToString()
        {
            return this.name + ", age " + this.MidiChlorianCount + " years";
        }
    }
}
