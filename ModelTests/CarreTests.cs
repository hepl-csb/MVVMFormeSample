using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass()]
    public class CarreTests
    {
        [DataTestMethod]
        [DataRow(0, 0, 2, 2)]
        [DataRow(2, 2, 2, 2)]
        [DataRow(2, 2, 5, 5)]
        public void CoordonneeEstDansTest(int x , int y, int x2, int y2)
        {
            var carre = new Carre(x, y, 4);
            Assert.IsTrue(carre.CoordonneeEstDans(new Coordonnees(x2, y2)));
        }

        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            var carre = new Carre(0,0,4);
            Assert.IsTrue(carre.CoordonneeEstDans(new Coordonnees(2, 2)));
        }

        [TestMethod()]
        public void CoordonneeEstDansMustFailTest()
        {
            var carre = new Carre(0, 0, 4);
            Assert.IsFalse(carre.CoordonneeEstDans(new Coordonnees(20, 20)));
        }

        [TestMethod()]
        public void CoordonneeEstDansNegativeTest()
        {
            var carre = new Carre(0, 0, 4);
            Assert.IsFalse(carre.CoordonneeEstDans(new Coordonnees(-2, -2)));
        }

        [TestMethod()]
        public void NbrSommetsTest()
        {
            var carre = new Carre(0, 0, 4);
            Assert.AreEqual(4, carre.NbrSommets());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareLongTest()
        {
            Assert.Fail();
        }
    }
}