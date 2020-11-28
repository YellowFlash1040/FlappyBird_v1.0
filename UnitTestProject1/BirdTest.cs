using System;
using FlappyBird_v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlappyBird_Tests
{
    [TestClass]
    public class BirdTest
    {
        [TestMethod]
        public void BirdMoveMethodTest()
        {
            Bird b1 = new Bird();
            b1.Move();
            Assert.AreEqual(new Vector(), b1.R);
        }

        [TestMethod]
        public void BirdChangeDirectionOfMoveMethodTest()
        {
            Bird b1 = new Bird();
            b1.ChangeDirectionOfMove();
            Assert.AreEqual(new Vector(), b1.R);
        }

        Timer t1 = new Timer();
        t1.Interval = 33;

        [TestMethod]
        public void BirdIsCollisionMethodTest()
        {
            Bird b1 = new Bird();
            b1.Move();
            Assert.AreEqual(new Vector(), b1.R);
        }
    }
}
