using Algo_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Head h = new Head();

            int ouput = 4;
            int real_output = h.SoldierBananas(3, 14, 9);

            Assert.AreEqual(ouput, real_output);
        }
    }
}
