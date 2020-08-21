using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InventoryProgram
{
    static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product> 
        {
            new Product("Red Bike", 55M, 20, 1, 100),
            new Product("Blue Bike", 60M, 20, 1, 100),
        };

        public static Product productIndex = null;

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part> 
        {
            new Outsourced("Wheel", 20.2M, 11, 1, 100, "Company"),
            new Outsourced("Pedal", 8.2M, 13, 1, 100, "Company"),
            new Inhouse("Chain", 11.3M, 12, 1, 100, 21243),
            new Inhouse("Seat", 17M, 15, 1, 100, 21243)
        };

        public static Part partsIndex = null;
        public static Outsourced outsource = null;
        public static Inhouse inhouse = null;

        static Inventory()
        {
            
        }



        ////Methods for Products
        public static void addProduct(Product newProduct, AddProduct_Form form)
        {
            newProduct.Name = form.ProductsName;
            newProduct.Price = Convert.ToDecimal(form.ProductsPrice);
            newProduct.InStock = Convert.ToInt32(form.ProductsInventory);
            newProduct.Min = Convert.ToInt32(form.ProductsMin);
            newProduct.Max = Convert.ToInt32(form.ProductsMax);

            Products.Add(newProduct);
        }

        public static bool deleteProduct(int index)
        {
            if(index >= 0)
            {
                if (Products[index].AssociatedParts.Count > 0)
                {
                        MessageBox.Show("You cannot delete a product that has parts associated with it.", "Product contains parts", MessageBoxButtons.OK);
                        return true;
                }

                var confirmDelete = MessageBox.Show("You are about to delete this product. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    Products.Remove(Products[index]);
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static Product lookupProduct(int id)
        {
            Product searchedItem = null;

            try
            {
                searchedItem = Products.First(item => item.ProductID == id);
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.", "No Results", MessageBoxButtons.OK);
                return null;
            }
        }
        //Overloaded product lookup method.
        public static Product lookupProduct(string name)
        {
            Product searchedItem = null;

            try
            {
                searchedItem = Products.First(item => item.Name.ToUpper().Contains(name.ToUpper()));
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.", "No Results", MessageBoxButtons.OK);
                return null;
            }
        }


        public static void updateProduct(Product product, ModifyProduct_Form form)
        {
            product.Name = form.ProductsName;
            product.ProductID = Convert.ToInt32(form.ProductsID);
            product.Price = Convert.ToDecimal(form.ProductsPrice);
            product.InStock = Convert.ToInt32(form.ProductsInventory);
            product.Min = Convert.ToInt32(form.ProductsMin);
            product.Max = Convert.ToInt32(form.ProductsMax);
        }




        //// Methods for Parts
        public static void addPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

        public static bool deletePart(Part selected)
        {
            if(selected != null)
            {
                var confirmDelete = MessageBox.Show("You are about to delete this part. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                if(confirmDelete == DialogResult.Yes)
                {
                    AllParts.Remove(selected);
                    partsIndex = null;
                    return true;
                }
                else
                {
                    return true;
                } 
            }
            else
            {
                return false;
            }  
        }
        
        public static Part lookupPart(int id)
        {
            Part searchedItem = null;

            try
            {
                searchedItem = AllParts.First(item => item.PartID == id);
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.","No Results", MessageBoxButtons.OK);
                return null;
            }
        }

        //// lookupPart is overloaded to allow searching by name
        public static Part lookupPart(string name)
        {
            Part searchedItem = null;

            try
            {
                searchedItem = AllParts.First(item => item.Name.ToUpper().Contains(name.ToUpper()));
                return searchedItem;
            }
            catch (Exception)
            {
                MessageBox.Show("No results were found.", "No Results", MessageBoxButtons.OK);
                return null;
            }
        }
        
        public static void updatePart(Part part, ModifyPart_Form form)
        {
            outsource = null;
            inhouse = null;

            if (form.OutsourcedIsChecked)
            {
                outsource = new Outsourced(Convert.ToInt32(form.PartID), 
                                           form.PartName,
                                           Convert.ToDecimal(form.PartPrice),
                                           Convert.ToInt32(form.InStock),
                                           Convert.ToInt32(form.PartMin),
                                           Convert.ToInt32(form.PartMax),
                                           form.PartCompanyName);
                
                AllParts.Insert(part.PartID, outsource);
            }
            else if (form.InHouseIsChecked)
            {
                inhouse = new Inhouse(Convert.ToInt32(form.PartID),
                                      form.PartName,
                                      Convert.ToDecimal(form.PartPrice),
                                      Convert.ToInt32(form.InStock),
                                      Convert.ToInt32(form.PartMin),
                                      Convert.ToInt32(form.PartMax),
                                      Convert.ToInt32(form.PartMachineID));
                
                AllParts.Insert(part.PartID, inhouse);
            }

            AllParts.Remove(part);
        }
        

        //Helper Methods

        public static bool ValidateNumericValues(string name, string price, string stock, string max, string min) 
        {
            if (string.IsNullOrWhiteSpace(name)) 
            {
                MessageBox.Show("Name must be at least one character long.", "Invalid Input");
                return false;
            }

            try
            {
                Convert.ToDecimal(price);
            }
            catch (Exception)
            {
                MessageBox.Show("Price must be a valid number with no letters or special characters.", "Invalid Input");
                return false;
            }

            try
            {
                Convert.ToInt32(stock);
            }
            catch (Exception)
            {
                MessageBox.Show("Inventory must be a valid number with no letters or special characters.", "Invalid Input");
                return false;
            }

            try
            {
                Convert.ToInt32(max);
            }
            catch (Exception)
            {
                MessageBox.Show("Max must be a valid number with no letters or special characters.", "Invalid Input");
                return false;
            }

            try
            {
                Convert.ToInt32(min);
            }
            catch (Exception)
            {
                MessageBox.Show("Min must be a valid number with no letters or special characters.", "Invalid Input");
                return false;
            }
            
            var stockNum = Convert.ToInt32(stock);
            var maxNum = Convert.ToInt32(max);
            var minNum = Convert.ToInt32(min);

            if (stockNum < minNum || stockNum > maxNum)
            {
                MessageBox.Show("Inventory must be between Min and Max values.", "Invalid Input");
                return false;
            }
            else if (minNum >= maxNum || maxNum <= minNum) 
            {
                MessageBox.Show("Min must be lower than Max. Max must be greater than Min.", "Invalid Input");
                return false;
            }

            return true;
        }

        public static bool ValidateMachineID(string machID) 
        {
            try
            {
                Convert.ToInt32(machID);
            }
            catch (Exception)
            {
                MessageBox.Show("Machine ID must be a valid number with no letters or special characters.", "Invalid Input");
                return false;
            }

            return true;
        }

        public static bool ValidateCompanyName(string company)
        {
            if (string.IsNullOrWhiteSpace(company)) 
            {
                MessageBox.Show("Company Name must be at least one character long.", "Invalid Input");
                return false;
            }

            return true;
        }
    }
}
