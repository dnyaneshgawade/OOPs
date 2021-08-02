using System;
using System.Collections.Generic;
using System.Text;

namespace EnventoryManagement
{
    public class InventoryStructure
    {
        public List<Rice> RiceList { get; set; }
        public List<Wheat> WheatList { get; set; }
        public List<Pulses> PulsesList { get; set; }
    }
}
