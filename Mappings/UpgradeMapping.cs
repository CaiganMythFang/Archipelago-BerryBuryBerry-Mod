using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerryAP.Mappings
{
    ///  Map the upgrades obtainable. Code is placeholder currently.
    
    class UpgradeMapping
    {
        public static Dictionary<int, (int itemid, string name, int count)> mapping = new Dictionary<int, (int itemid, string name, int count)>
        {
            {0, (1, "Berry Buddy", 6) },
            {1, (2, "Movable Hole", 6) },
            {2, (3, "Vaccuum Unlock", 1) }
        };
    }
}
