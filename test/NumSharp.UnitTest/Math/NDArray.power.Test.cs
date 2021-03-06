using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NumSharp.Core;

namespace NumSharp.UnitTest
{
    [TestClass]
    public class PowerTest
    {
        [TestMethod]
        public void PowerWithSingleValue()
        {
            var nd = np.arange(3);
            
            var nd1 = nd.power(2).MakeGeneric<double>();
            
            Assert.IsTrue(nd1[0] == 0);
            Assert.IsTrue(nd1[1] == 1);
            Assert.IsTrue(nd1[2] == 4);
        }
    }
}
