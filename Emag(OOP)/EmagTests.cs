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

            var phone1 = new Phone(specFirstPhone, Promotion.New, 20, PhoneNames.LGG6);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion, 50, PhoneNames.IPHONE7);
            var phone3 = new Phone(specThirdPhone, Promotion.New, 25, PhoneNames.S7EDGE);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed, 15, PhoneNames.S8PLUS);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            Spec spec = new Spec(2, 5, 0);
            var givenCriterias = new Phone(spec, Promotion.Promotion, 0, 0);

            CollectionAssert.AreEqual(new Phone[1] { phone2 }, phonelist.FindPhones(givenCriterias));
        }

        [TestMethod]
        public void EmagTest2()
        {
            var specFirstPhone = new Spec(2, 5.5m, 32);
            var specSecondPhone = new Spec(2, 5m, 64);
            var specThirdPhone = new Spec(1, 4.5m, 16);
            var specFourthPhone = new Spec(4, 5.5m, 64);

            var phone1 = new Phone(specFirstPhone, Promotion.New, 20, PhoneNames.LGG6);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion, 50, PhoneNames.IPHONE7);
            var phone3 = new Phone(specThirdPhone, Promotion.New, 25, PhoneNames.S7EDGE);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed, 15, PhoneNames.S8PLUS);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            Spec spec = new Spec(2, 0, 0);
            var givenCriterias = new Phone(spec, 0, 0, 0);

            CollectionAssert.AreEqual(new Phone[3] { phone1, phone2, phone4 }, phonelist.FindPhones(givenCriterias));
        }

        [TestMethod]
        public void EmagTest3()
        {
            var specFirstPhone = new Spec(2, 5.5m, 32);
            var specSecondPhone = new Spec(2, 5m, 64);
            var specThirdPhone = new Spec(1, 4.5m, 16);
            var specFourthPhone = new Spec(4, 5.5m, 64);

            var phone1 = new Phone(specFirstPhone, Promotion.New, 20, PhoneNames.LGG6);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion, 50, PhoneNames.IPHONE7);
            var phone3 = new Phone(specThirdPhone, Promotion.New, 25, PhoneNames.S7EDGE);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed, 15, PhoneNames.S8PLUS);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            Spec spec = new Spec(1, 4.5m, 0);
            var givenCriterias = new Phone(spec, 0, 0, 0);

            CollectionAssert.AreEqual(new Phone[4] { phone1, phone2, phone3, phone4 }, phonelist.FindPhones(givenCriterias));
        }

        [TestMethod]
        public void EmagTest4()
        {
            var specFirstPhone = new Spec(2, 5.5m, 32);
            var specSecondPhone = new Spec(2, 5m, 64);
            var specThirdPhone = new Spec(1, 4.5m, 16);
            var specFourthPhone = new Spec(4, 5.5m, 64);

            var phone1 = new Phone(specFirstPhone, Promotion.New, 20, PhoneNames.LGG6);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion, 50, PhoneNames.IPHONE7);
            var phone3 = new Phone(specThirdPhone, Promotion.New, 25, PhoneNames.S7EDGE);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed, 15, PhoneNames.S8PLUS);
            var phone2Sell = new Phone(specSecondPhone, Promotion.Promotion, 30, PhoneNames.IPHONE7);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            int sellNumber = 20;

            Assert.AreEqual(30, phone2.PhoneSubtract(sellNumber));
        }

        [TestMethod]
        public void EmagTest5()
        {
            var specFirstPhone = new Spec(2, 5.5m, 32);
            var specSecondPhone = new Spec(2, 5m, 64);
            var specThirdPhone = new Spec(1, 4.5m, 16);
            var specFourthPhone = new Spec(4, 5.5m, 64);

            var phone1 = new Phone(specFirstPhone, Promotion.New, 20, PhoneNames.LGG6);
            var phone2 = new Phone(specSecondPhone, Promotion.Promotion, 50, PhoneNames.IPHONE7);
            var phone3 = new Phone(specThirdPhone, Promotion.New, 25, PhoneNames.S7EDGE);
            var phone4 = new Phone(specFourthPhone, Promotion.Resealed, 15, PhoneNames.S8PLUS);
            var phone2Sell = new Phone(specSecondPhone, Promotion.Promotion, 30, PhoneNames.IPHONE7);
            PhoneList phonelist = new PhoneList(new Phone[4] { phone1, phone2, phone3, phone4 });
            int sellNumber = 10;

            Assert.AreEqual(10, phone1.PhoneSubtract(sellNumber));
        }
    }
}
