#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion

namespace NoReferenceTest
{
    using ExternalAdvices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BasicTest
    {
        public class AdvisedMethodClass
        {
            [LooseAdvice]
            public int AMethod(int a)
            {
                return a + 1;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            var c = new AdvisedMethodClass();
        }
    }
}
