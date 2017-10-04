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

    public enum PhoneNames
    {
        IPHONE7,
        S7EDGE,
        S8PLUS,
        LGG6
    }

    public class Phone
    {
        private Spec spec;
        private Promotion promotion;
        private int stoc;
        private PhoneNames name;

        public Phone(Spec spec, Promotion promotion, int stoc, PhoneNames name)
        {
            this.spec = spec;
            this.promotion = promotion;
            this.stoc = stoc;
            this.name = name;
        }

        public bool Compare(Phone another)
        {
            return (spec.CompareRam(another.spec) 
                && spec.CompareInternalMemory(another.spec) 
                && spec.CompareDisplaySize(another.spec) 
                && (promotion == another.promotion || another.promotion == 0));
        }
        public bool FindPhone(PhoneNames phoneName)
        {
            return (name == phoneName);
        }

        public int SellPhone(int sellNumber)
        {
            stoc = stoc - sellNumber;
            return stoc;
        }
    }

}
