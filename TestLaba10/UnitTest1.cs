using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba_10;
using System.Collections.Generic;

namespace TestLaba10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor()
        {
            Goods g = new Goods("Стол", 5000);
            Toy t = new Toy("Кукла", 200, "Россия");
            Product p = new Product("Колбаса", 100, 10, 10, 2020);
            Milk m = new Milk("Масло", 50, 5, 5, 2020, 70);
            //Assert
            Assert.AreEqual("Товар: Стол \nСтоимость: 5000", g.ToString());
            Assert.AreEqual("Товар: Кукла \nСтоимость: 200\nПроизводитель: Россия", t.ToString());
            Assert.AreEqual("Товар: Колбаса \nСтоимость: 100\nСрок годности: 10.10.2020", p.ToString());
            Assert.AreEqual("Товар: Масло \nСтоимость: 50\nСрок годности: 05.05.2020\nЖирность: 70%", m.ToString());
        }

        [TestMethod]
        public void TestEmptyConstructor()
        {
            Goods g = new Goods();
            Toy t = new Toy();
            Product p = new Product();
            Milk m = new Milk();
            //Assert
            Assert.AreEqual("Товар: Не указано \nСтоимость: 0", g.ToString());
            Assert.AreEqual("Товар: Не указано \nСтоимость: 0\nПроизводитель: Не указано", t.ToString());
            Assert.AreEqual("Товар: Не указано \nСтоимость: 0\nСрок годности: 01.01.0001", p.ToString());
            Assert.AreEqual("Товар: Не указано \nСтоимость: 0\nСрок годности: 01.01.0001\nЖирность: 0%", m.ToString());
        }

        [TestMethod]
        public void TestProperty()
        {
            Goods g1 = new Goods();
            Goods g2 = new Goods();
            //Act
            g2.Name = "Стол";
            //Assert
            Assert.AreEqual("Стол", g2.Name);
            Assert.AreEqual("Не указано", g1.Name);
        }

        [TestMethod]
        public void TestClone()
        {
            Goods g = new Goods("Стол", 5000);
            Toy t = new Toy("Кукла", 200, "Россия");
            Product p = new Product("Колбаса", 100, 10, 10, 2020);
            Milk m = new Milk("Масло", 50, 5, 5, 2020, 70);
            //Act
            Goods gClon = (Goods) g.Clone();
            Toy tClon = (Toy) t.Clone();
            Product pClon = (Product) p.Clone();
            Milk mClon = (Milk) m.Clone();
            //Assert
            Assert.AreEqual(g.ToString(), gClon.ToString());
            Assert.AreEqual(t.ToString(), tClon.ToString());
            Assert.AreEqual(p.ToString(), pClon.ToString());
            Assert.AreEqual(m.ToString(), mClon.ToString());
        }

        [TestMethod]
        public void TestSort()
        {
            Goods g = new Goods("Стол", 5000);
            Toy t = new Toy("Кукла", 50, "Россия");
            Product p = new Product("Колбаса", 100, 10, 10, 2020);
            Milk m = new Milk("Масло", 150, 5, 5, 2020, 70);
            Milk m2 = new Milk("Сыр", 150, 5, 5, 2020, 70);

            IExecutable[] mas = new IExecutable[5];
            //Act
            mas[0] = g;
            mas[1] = t;
            mas[2] = p;
            mas[3] = m;
            mas[4] = m2;
            Array.Sort(mas);
            //Assert
            Assert.AreEqual(t.ToString(), mas[0].ToString());
            Assert.AreEqual(g.ToString(), mas[4].ToString());
        }

        [TestMethod]
        public void TestSortByName()
        {
            Goods g = new Goods("Стол", 1000);
            Toy t = new Toy("Кукла", 500, "Россия");
            Product p = new Product("Колбаса", 100, 10, 10, 2020);
            Milk m = new Milk("Масло", 150, 5, 5, 2020, 70);
            IExecutable[] mas = new IExecutable[4];
            //Act
            mas[0] = g;
            mas[1] = t;
            mas[2] = p;
            mas[3] = m;
            Array.Sort(mas, new SortByName());
            //Assert
            Assert.AreEqual(p.ToString(), mas[0].ToString());
            Assert.AreEqual(g.ToString(), mas[3].ToString());
        }
    }
}
