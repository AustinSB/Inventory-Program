using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        private static int generateProductID = 1000;

        public Product(string name, decimal price, int inStock, int min, int max)
        {
            ProductID = ++generateProductID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        //Alternative constructor if a product has parts associated with it.
        public Product(string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            ProductID = ++generateProductID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }

        public void addAssociatedPart(Part associated)
        {
            this.AssociatedParts.Add(associated);
        }

        public bool removeAssociatedPart(int partID)
        {
            var confirmDelete = MessageBox.Show("You are about to delete this associated part. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                foreach (var part in this.AssociatedParts)
                {
                    if (part.PartID == partID)
                    {
                        this.AssociatedParts.Remove(part);
                        return true;
                    }
                }
            }
            else 
            {
                return true;
            }

            return false;
        }

        public Part lookupAssociatedPart(int id)
        {
            Part searchedItem = null;

            try
            {
                searchedItem = this.AssociatedParts.First(item => item.PartID == id);
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.", "No Results", MessageBoxButtons.OK);
                return null;
            }
        }

        public Part lookupAssociatedPart(string name)
        {
            Part searchedItem = null;

            try
            {
                searchedItem = this.AssociatedParts.First(item => item.Name.ToUpper().Contains(name.ToUpper()));
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.", "No Results", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
