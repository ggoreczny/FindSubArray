using NUnit.Framework;

namespace FindArray.Tests
{
    [TestFixture]
    public class MyFindArrayTests
    {
        [TestCase(new int[] { 4, 9, 3, 7, 8 }, new [] { 3, 7 }, 2)]
        [TestCase(new int[] { 1, 3, 5 }, new [] { 1 }, 0)]
        [TestCase(new int[] { 1, 3, 5 }, new int[] { }, -1)]
        [TestCase(new int[] { 1 }, new [] { 3, 5, 5 }, -1)]
        public void TestFindArray(int[] array, int[] subArray, int expected)
        {
            var findArray = new MyFindArray();
            var result = findArray.FindArray(array, subArray);

            Assert.AreEqual(expected, result);
        }
    }
}
