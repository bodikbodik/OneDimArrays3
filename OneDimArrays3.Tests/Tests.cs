using NUnit.Framework;
using System.Collections;

namespace OneDimArrays3.Tests
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable Task1TestCases()
        {
            yield return new TestCaseData(new[] { -37, 32, 0, 20, -18 }, (-3, 4));
            yield return new TestCaseData(new[] { 0, -11, 8, 0, -2, -27 }, (-32, 4));
            yield return new TestCaseData(new[] { -11, 0, -9, -7, -6, 0, 11, 14 }, (-8, 6));
        }

        [TestCaseSource(nameof(Task1TestCases))]
        public void Task1_ReturnsCorrectValue(int[] array, (int, int) expected)
        {
            var actual = Tasks.Task1(array);

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(new[] { -37, 32, 0, 20, -18 }, 0, 26)]
        [TestCase(new[] { 0, -11, 8, 0, -2, -27 }, 2, 8)]
        [TestCase(new[] { -11, 0, -9, -7, -6, 0, 11, 14 }, -7, 3.8)]
        public void Task2_ReturnsCorrectValue(int[] array, int a, double expected)
        {
            var actual = Tasks.Task2(array, a);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(new[] { -37, 32, 0, 20, -18 }, 69)]
        [TestCase(new[] { 0, -11, 8, 0, -2, -27 }, 35)]
        [TestCase(new[] { -11, 0, -9, -7, -6, 0, 11, 14 }, 25)]
        public void Task3_ReturnsCorrectValue(int[] array, int expected)
        {
            var actual = Tasks.Task3(array);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}
