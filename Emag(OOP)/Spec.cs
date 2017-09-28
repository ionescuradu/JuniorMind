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

        public bool CompareRam(Spec spec)
        {
            return (ram >= spec.ram) || (spec.ram == 0);
        }

        public bool CompareDisplaySize(Spec spec)
        {
            return (displaySize >= spec.displaySize) || (spec.displaySize == 0);
        }

        public bool CompareInternalMemory(Spec spec)
        {
            return (internalMemory >= spec.internalMemory) || (spec.internalMemory == 0);
        }

    }

}
