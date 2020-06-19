using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astor.Linq.Tests
{
    [TestClass]
    public class Slices_Should
    {
        [TestMethod]
        public void CreateThreeSlicesOfHundred_WhenThreeHundredSlicedByHundred()
        {
            var source = Enumerable.Range(0, 300);
            var slices = source.Slices(100);

            Assert.AreEqual(3, slices.Count());

            foreach (var slice in slices)
            {
                Assert.AreEqual(100, slice.Count());
            }
        }

        [TestMethod]
        public void CreateSliceOfHundredAndSliceOfFifty_WhenHundredAndHalfSlicedByHundred()
        {
            var source = Enumerable.Range(0, 150);
            var slices = source.Slices(100);

            Assert.AreEqual(2, slices.Count());
            Assert.AreEqual(100, slices.ElementAt(0).Count());
            Assert.AreEqual(50, slices.ElementAt(1).Count());
        }

        [TestMethod]
        public void CreateZeroSlices_WhenSourceEnumerableEmpty()
        {
            var source = Enumerable.Range(0, 0);
            var slices = source.Slices(100);

            Assert.AreEqual(0, slices.Count());
        }

        [TestMethod]
        public void CreateOneSliceWithTenElements_WhenSourceEnumerableHasTenElementsAndSeparatedByHundred()
        {
            var source = Enumerable.Range(0, 10);
            var slices = source.Slices(100);

            Assert.AreEqual(1, slices.Count());
            Assert.AreEqual(10, slices.ElementAt(0).Count());
        }
    }
}