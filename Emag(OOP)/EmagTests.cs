using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emag_OOP_
{
    [TestClass]
    public class EmagTests
    {
        [TestMethod]
        public void EmagTest1()
        {
            var specFirstPhone = new Spec(2, 5.5m, 32);
            var specSecondPhone = new Spec(2, 5m, 64);
            var specThirdPhone = new Spec(1, 4.5m, 16);
            var specFourthPhone = new Spec(4, 5.5m, 64);

            var phone1 = new Phone(specFirstPhone, Promotion.New);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion);
            var phone3 = new Phone(specThirdPhone, Promotion.New);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            Spec spec = new Spec(2, 5, 0);
            var givenCriterias = new Phone(spec, Promotion.Promotion);

            CollectionAssert.AreEqual(new Phone[1] { phone2 }, phonelist.FindPhones(givenCriterias));
        }
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
}
