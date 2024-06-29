using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenBailey_InventorySystem.Models
{
    public class InHousePart : Part
    {

        public InHousePart(int partID, string name, decimal price, int inventory, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
            Source = true; //True if in-house, false if outsourced
            MachineID = machineID;
        }
    }
}
