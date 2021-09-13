using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba_13;

namespace Laba_13_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            NewQueue<Goods> que = new NewQueue<Goods>();
            que.Name = "2";

            Journal joun = new Journal();
            que.CollectionCountChanged += new CollectionHandler(joun.CollectionCountChanged);

            Goods g = Goods.CreateRandom();
            //act

            que.AddLast(g);

            //accept
            Assert.AreEqual(g.ToString(), que.End.ToString());
            Assert.AreEqual("В коллекции: 2 произошло событие: AddLast\n" +
                            "Подробности: " + g.ToString(), joun.journal[0].ToString());

        }

        [TestMethod]
        public void testDelete()
        {
            NewQueue<Goods> que = new NewQueue<Goods>();
            que.Name = "2";

            Journal joun = new Journal();
            que.CollectionCountChanged += new CollectionHandler(joun.CollectionCountChanged);

            Goods g = Goods.CreateRandom();
            //act

            que.AddLast(g);
            que.DeleteFirst();

            //accept
            Assert.AreEqual(g.ToString(), que.End.ToString());
            Assert.AreEqual("В коллекции: 2 произошло событие: DeleteFirst\n" +
                            "Подробности: " + g.ToString(), joun.journal[1].ToString());

        }

        [TestMethod]
        public void TestChenge()
        {
            NewQueue<Goods> que = new NewQueue<Goods>();
            que.Name = "2";

            Journal joun = new Journal();
            que.CollectionReferenceChanged += new CollectionHandler(joun.CollectionReferenceChanged );

            Goods g1 = Toy.CreateRandom();
            Goods g2 = Goods.CreateRandom();
            Goods g3 = Goods.CreateRandom();
            //act

            que.AddLast(g1);
            que.AddLast(g2);
            que.Begin = new Point<Goods>(g3);


             
            //accept
            Assert.AreEqual(que.Begin.ToString(), g3.ToString());
            Assert.AreEqual("В коллекции: 2 произошло событие: changedFirst\nПодробности: " + g3.ToString(), joun.journal[0].ToString());
        }
    }
}
