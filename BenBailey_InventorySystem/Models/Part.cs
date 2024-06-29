using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenBailey_InventorySystem.Models
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        private bool source;
        private int machineID;
        private string companyName;

        
        public int PartID 
        {
            get
            {
                return partID;
            }
            set
            {
                partID = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Inventory
        {
            get
            {
                return inStock;
            }
            set
            {
                inStock = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }
        }
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
            }
        }
        public bool Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public void SetPartId(int partID)
        {
            this.partID = partID;
        }
        public int GetPartId()
        {
            return partID;
        }

        public int MachineID
        {
            get
            {
                return machineID;
            }
            set
            {
                machineID = value;
            }
        }

        // public virtual int MachineID { get; set; }
        public virtual string CompanyName { get; set; }
        
        //public virtual int GetMachineID() { return 0; }
        //public string CompanyName 
        //{
        //    get
        //    {
        //        return companyName;
        //    }
        //    set
        //    {
        //        companyName = value;
        //    }
        //}
        
        //public Part() { }

        //public Part(string name, decimal price, int inventory, int min, int max)
        //      : this(Models.Inventory.GetNextPartID(), name, price, inventory, min, max) { }

        //public Part(int partID, string name, decimal price, int inventory, int min, int max, bool source)
        //{
        //    PartID = partID;
        //    Name = name;
        //    Price = price;
        //    Inventory = inventory;
        //    Min = min;
        //    Max = max;
        //    Source
        //}


        //{
        //    get { return price.ToString("C"); } 
        //    set
        //    {
        //        if (value.StartsWith("$"))
        //        {
        //            price = decimal.Parse(value.Substring(1));
        //        }
        //        else
        //        {
        //            price = decimal.Parse(value);
        //        }

        //    }
        //}


    }
}
