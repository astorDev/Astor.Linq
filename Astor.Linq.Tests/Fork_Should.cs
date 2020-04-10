using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astor.Linq.Tests
{
    [TestClass]
    public class Fork_Should
    {
        [TestMethod]
        public void SeparateEvenAndOddNumbers()
        {
            var sequence = new[] {1, 1, 4, 5, 6, 800, 901};
            var (even, odd) = sequence.Fork(n => n % 2 == 0);
            
            Assert.IsTrue(even.SequenceEqual(new []{4, 6, 800}));
            Assert.IsTrue(odd.SequenceEqual(new [] {1, 1, 5, 901}));
        }
    }
}