using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame.Sources.Models
{
    public class Stats
    {
        public double strength { get; set; }
        public double dexterity { get; set; }
        public double constitution { get; set; }
        public double intelligence { get; set; }
        public Stats(double strenghtparam, double dexterityparam, double constitutionparam, double intelligenceparam) 
        {
            strength = strenghtparam;
            dexterity = dexterityparam;
            constitution = constitutionparam;
            intelligence = intelligenceparam;
        }
    }
}
