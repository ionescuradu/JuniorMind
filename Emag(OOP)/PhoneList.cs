using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emag_OOP_
{
    public class PhoneList
    {
        public Phone[] phoneList;

        public PhoneList(Phone[] phoneList)
        {
            this.phoneList = phoneList;
        }

        public Phone[] FindPhones(Phone givenCriterias)
        {
            int count = 0;
            var aux = new Phone[count];
            for (int i = 0; i < phoneList.Length; i++)
            {
                if (phoneList[i].Compare(givenCriterias) == true)
                {
                    Array.Resize(ref aux, count + 1);
                    aux[count] = phoneList[i];
                    count += 1;
                }
            }
            return aux;
        }

        public int SellPhone(PhoneNames phoneName, int sellNumber)
        {
            int remainingStoc = 0;
            for (int i = 0; i < phoneList.Length; i++)
            {
                if (phoneList[i].FindPhone(phoneName) == true)
                {
                    remainingStoc = phoneList[i].SellPhone(sellNumber);
                }
            }
            return remainingStoc;
        }

    }
}
