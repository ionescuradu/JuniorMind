using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emag_OOP_
{
    public enum Promotion
    {
        Stoc,
        Promotion,
        New,
        Sales,
        Resealed,
        Preorder
    }
    public class Phone
    {
        private Spec spec;
        private Promotion promotion;

        public Phone(Spec spec, Promotion promotion)
        {
            this.spec = spec;
            this.promotion = promotion;
        }

        public bool Compare(Phone another)
        {
            return (spec.CompareRam(another.spec) && spec.CompareInternalMemory(another.spec) && spec.CompareDisplaySize(another.spec) && (promotion == another.promotion || another.promotion == 0));
        }
    }

}
