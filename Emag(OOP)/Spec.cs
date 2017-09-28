using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emag_OOP_
{
    public class Spec
    {
        private int ram;
        private decimal displaySize;
        private int internalMemory;

        public Spec(int ram, decimal displaySize, int internalMemory)
        {
            this.ram = ram;
            this.displaySize = displaySize;
            this.internalMemory = internalMemory;
        }

        public bool CompareRam(Phone another)
        {
            return (ram >= another.spec.ram) || (another.spec.ram == 0);
        }

        public bool CompareDisplaySize(Phone another)
        {
            return (displaySize >= another.spec.displaySize) || (another.spec.displaySize == 0);
        }

        public bool CompareInternalMemory(Phone another)
        {
            return (internalMemory >= another.spec.internalMemory) || (another.spec.internalMemory == 0);
        }

    }

}
