using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenBailey_InventorySystem.Models
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void PopulateLists()
        {
            Product dummyProd1 = new Product(1, "Product A", 5.99m, 3, 1, 5);
            Product dummyProd2 = new Product(2, "Product B", 4.99m, 6, 2, 10);
            Product dummyProd3 = new Product(3, "Product C", 3.99m, 9, 3, 15);
            Product dummyProd4 = new Product(4, "Product D", 2.99m, 12, 4, 20);
            Product dummyProd5 = new Product(5, "Product E", 1.99m, 15, 5, 25);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);
            Products.Add(dummyProd5);

            Part dummyPart1A = new InHousePart(1, "Part 1.A", 5.00m, 15, 10, 25, 001);
            Part dummyPart1B = new InHousePart(2, "Part 1.B", 4.00m, 10, 10, 25, 002);
            Part dummyPart2A = new InHousePart(3, "Part 2.A", 8.00m, 12, 10, 25, 003);
            Part dummyPart2B = new InHousePart(4, "Part 2.B", 3.00m, 15, 10, 25, 004);
            Part dummyPart3A = new OutsourcedPart(5, "Part 3.A", 25.00m, 15, 10, 30, "RogueCorp");
            Part dummyPart3B = new OutsourcedPart(6, "Part 3.B", 19.00m, 10, 10, 25, "RogueCorp");
            Part dummyPart4A = new OutsourcedPart(7, "Part 4.A", 13.00m, 12, 10, 25, "StrikeCo");
            Part dummyPart4B = new OutsourcedPart(8, "Part 4.B", 7.00m, 15, 10, 25, "StrikeCo");

            Parts.Add(dummyPart1A);
            Parts.Add(dummyPart1B);
            Parts.Add(dummyPart2A);
            Parts.Add(dummyPart2B);
            Parts.Add(dummyPart3A);
            Parts.Add(dummyPart3B);
            Parts.Add(dummyPart4A);
            Parts.Add(dummyPart4B);

            // Add parts to respective Products
            dummyProd1.AssociatedParts.Add(dummyPart1A);
            dummyProd1.AssociatedParts.Add(dummyPart1B);
            dummyProd2.AssociatedParts.Add(dummyPart2A);
            dummyProd2.AssociatedParts.Add(dummyPart2B);
            dummyProd3.AssociatedParts.Add(dummyPart3A);
            dummyProd3.AssociatedParts.Add(dummyPart3B);
            dummyProd4.AssociatedParts.Add(dummyPart4A);
            dummyProd4.AssociatedParts.Add(dummyPart4B);
        }


        //Products
        public static int GetNextProductID()
        {
            return Products.Count + 1;
        }
        
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }
        
        public bool DeleteProduct(int productID)
        {
            bool deleteSuccess = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return deleteSuccess = true;
                }
                else
                {
                    MessageBox.Show("Delete unsuccessful.");
                    return false;
                }
            }
            return deleteSuccess;
        }

        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product prodNotExist = new Product();
            return prodNotExist;
        }

        public static void UpdateProduct(int productID, Product updateProduct)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    prod.Name = updateProduct.Name;
                    prod.Price = updateProduct.Price;
                    prod.Inventory = updateProduct.Inventory;
                    prod.Min = updateProduct.Min;
                    prod.Max = updateProduct.Max;
                    prod.AssociatedParts = updateProduct.AssociatedParts;
                    return;
                }
            }
        }
        
        //Parts
        public static int GetNextPartID()
        {
            return Parts.Count + 1;
        }
        
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        
        public static bool DeletePart(int partID)
        {
            bool deleteSuccess = false;

            foreach (Part p in Parts)
            {
                if (p.PartID == partID)
                {
                    Parts.Remove(p);
                    return deleteSuccess = true;
                }
                else
                {
                    MessageBox.Show("Delete unsucessful");
                    return false; 
                }
            }
            return deleteSuccess;
        }

        public static Part LookupPart(int partID)
        {
            Part partNotExist = null;
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return partNotExist;
        }
        
        // TODO: DELETE? 
        public static void UpdatePart(int partID, Part revisedPart)
        {
            Part oldPart = Parts.Where(i => i.PartID == partID).First();
            var index = Parts.IndexOf(oldPart);

            if (index != -1)
            {
                Parts[index] = revisedPart;
            }
            else
            {
                oldPart = revisedPart;
            }
        }
        
        public static void UpdateInHousePart(int partID, InHousePart iPart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (partID == Parts[i].PartID && Parts[i] is OutsourcedPart)
                {
                    var outSourcedPart = (OutsourcedPart)Parts[i];
                    var inHousePart = new InHousePart(partID, iPart.Name, iPart.Price, iPart.Inventory, iPart.Min, iPart.Max, iPart.MachineID);

                    Parts[i] = inHousePart;

                    break;
                }
            }
        }

        public static void UpdateOutsourcedPart(int partID, OutsourcedPart oPart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (partID == Parts[i].PartID && Parts[i] is InHousePart)
                {
                    var inHousePart = (InHousePart)Parts[i]; // Cast the Part object to an InHousePart object
                    var outsourcedPart = new OutsourcedPart(partID, oPart.Name, oPart.Price, oPart.Inventory, oPart.Min, oPart.Max, oPart.CompanyName); // Create a new OutsourcedPart object with the updated properties

                    // Update the Parts list with the new OutsourcedPart object
                    Parts[i] = outsourcedPart;

                    break; // Exit the loop since we found the part we were looking for
                }
            }
        }

    }
}


