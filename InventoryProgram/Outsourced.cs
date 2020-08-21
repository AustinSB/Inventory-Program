using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    public class Outsourced : Part
    {
        private string companyName;

        public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName)
        : base(name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        //alternate constructor
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                if(value != String.Empty)
                {
                    companyName = value;
                }
            }
        }
    }
}
