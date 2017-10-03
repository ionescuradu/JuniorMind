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

    }
}
