using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenBailey_InventorySystem.Models
{
    public class OutsourcedPart : Part
    {
        private string companyName;
        
        public override string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        //public OutsourcedPart(string name, decimal price, int inventory, int min, int max)
        //    : base(name, price, inventory, min, max)
        //{
        //    CompanyName = companyName;
        //}

        //public OutsourcedPart(int partID, string name, decimal price, int inventory, int min, int max)
            
        //{
        //    //PartID = partID;
        //    //Name = name;
        //    //Price = price;
        //    //Inventory = inStock;
        //    //Min = min;
        //    //Max = max;
        //    CompanyName = companyName;
        //}
        
        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Inventory = inStock;
            Min = min;
            Max = max;
            Source = false; //True if in-house, false if outsourced
            CompanyName = companyName;
        }
    }
}
