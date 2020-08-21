using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram
{
    class Inhouse : Part
    {
        private int machineID;

        public Inhouse(string name, decimal price, int inStock, int min, int max, int machineID)
        : base(name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        //alternate constructor
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }


        public int MachineID
        {
            get
            {
                return machineID;
            }
            set
            {
                if (value != 0)
                {
                    machineID = value;
                }
            }
        }
    }
}
