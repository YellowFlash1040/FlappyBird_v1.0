using System;
using FlappyBird_v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlappyBird_Tests
{
    [TestClass]
    public class WallTests
    {
        [TestMethod]
        public void TestWallMoveMethod()
        {
            Vector direction = new Vector(-10, 0);
            Wall w1 = new Wall(10, 10, new Vector(0,100));

            w1.Move(direction);
            Assert.AreEqual(new Vector(-10, 100), w1.R);
        }
    }
}
