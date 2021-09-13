using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba9;

namespace Laba_9_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstr()
        {
            //Arrnge
            Money m1 = new Money(); //создание пустого объекта
            //Act
            Money m2 = new Money(0, 0); //создание объекта с нолями
            Money m3 = new Money(0, 200);
            //Assert
            Assert.AreEqual(m1.ToString(), m2.ToString());
            Assert.AreEqual(m3.ToString(), new Money(2, 0).ToString());
        }
        [TestMethod]
        public void TestDiference()
        {
            //Arrange
            Money t = new Money(1, 0);
            Money t1 = new Money(0, 50);
            //Act

            Money t2 = Money.Difference(t, t1);
            Money t3 = t.Difference(t1);
            Money t4 = Money.Difference(t1, new Money(0, 25));
            //Assert
            t = new Money(0, 25);
            Assert.AreEqual(new Money(0, 50).ToString(), t2.ToString());
            Assert.AreEqual(new Money(0, 50).ToString(), t3.ToString());
            Assert.AreEqual(new Money(0, 25).ToString(), t4.ToString());

        }

        [TestMethod]
        public void TestExept()
        {
            //Arrange
            Money t = new Money(1, 0);
            Money t1 = new Money(0, 50);
            try
            {
                //Act                
                Money t3 = Money.Difference(t1, t);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Невозможно вычислить");
            }

            try
            {
                Money m = t - 4;
            }
            catch (Exception e)
            {
                Assert.AreEqual("Невозможно вычислить", e.Message);
            }

            try
            {
                Money m = new Money (-2, 0);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Отрицательная денежная сумма", e.Message);
            }

            try
            {
                Money m = new Money(0, -10);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Отрицательная денежная сумма", e.Message);
            }
        }

        [TestMethod]
            public void TestOper()
            {
            //Arrnge
            Money money1 = new Money(25, 60);
            Money money2 = new Money(15, 77);

            Money mCop11 = new Money(1, 10);
            Money mCop12 = new Money(3, 0);
            Money mCop2 = new Money(3, 99);
            //Act
            Money m1 = money1 - 10;//вычитание числа
            Money m2 = 30 - money1;//вычитание из числа
            Money m3 = money1 - money2;//вычитание из объекта

            mCop11--;
            mCop12--;
            mCop2++;             
            //Assert
            Assert.AreEqual("15 р. 60 коп.", m1.ToString());
            Assert.AreEqual("4 р. 40 коп.", m2.ToString());
            Assert.AreEqual("9 р. 83 коп.", m3.ToString());

            Assert.AreEqual("1 р. 9 коп.", mCop11.ToString());
            Assert.AreEqual("2 р. 99 коп.", mCop12.ToString());
            Assert.AreEqual("4 р. 0 коп.", mCop2.ToString());
            
            Assert.IsFalse(m1 == m2);
            Assert.IsTrue(m1 == m1);

            Assert.IsTrue(m1 != m2);
            Assert.IsFalse(m1 != m1);

            Assert.IsFalse(m1 < m2);
            Assert.IsTrue(m2 < m1);

            Assert.IsTrue(m1 > m2);


            Assert.AreEqual((int)money1, 25);
            Assert.AreEqual(money1/1.0, 0.60);
        }
         
        [TestMethod]
        public void TestCount()
        {
            //Arrange
            Money t = new Money();
            Money t1 = new Money();
            Money t2 = new Money();
            Money t3 = new Money();
        //Asser
        Assert.AreEqual(44, Money.Count);
        }
        }

    [TestClass]
    public class MoneyArrayTest
    {
        [TestMethod]
        public void TestConstr()
        {
            //Arrange
            MoneyArray mArr1 = new MoneyArray();
            //Act
            //Assert
            Assert.AreEqual("Массив не создан", mArr1.ToString());
        }

        [TestMethod]
        public void TestAccs()
        {
            //Arrange
            MoneyArray mArr = new MoneyArray(10, 10);
            Money mT = new Money(0, 25);
            //Act
            mArr[4] = mT;
            Money mNull = mArr[11];
            //Assert
            Assert.AreEqual(mArr[4].ToString(), mT.ToString());
            Assert.AreEqual(null, mNull);
        }

            
        [TestMethod]
        public void TestMax()
        {
            //Arrange
            MoneyArray mArr = new MoneyArray(10, 10);//максимальное значение 10 р
            Money m = new Money(20, 0);//20р
            //Act
            mArr[8] = m;
            Money max = mArr.Max();            
            //Assert
            Assert.AreEqual(m.ToString(), max.ToString());
        }
        [TestMethod]
        public void TestLength()
        {
            //Arrange
            MoneyArray mArr = new MoneyArray(10, 10);
            MoneyArray mArr1 = new MoneyArray();
            //Assert
            Assert.AreEqual(10, mArr.Length);
            Assert.AreEqual(0, mArr1.Length);
        }

        [TestMethod]
        public void TestConvertString()
        {
            //Arrange
            MoneyArray mArr = new MoneyArray(3, 10);
            Money m = new Money(10, 10);
            //Act
            mArr[0] = m;
            mArr[1] = m;
            mArr[2] = m;
            //Assert
            Assert.AreEqual("10 р. 10 коп.; 10 р. 10 коп.; 10 р. 10 коп.; ", mArr.ToString());
            
        }
    }    
}

