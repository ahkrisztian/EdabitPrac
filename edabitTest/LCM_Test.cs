using NUnit.Framework;
using edabit.Schwer;

namespace edabitTest
{
    public class Tests
    {

        [Test]
        public void Search_Least_Common_Multiple()
        {
            //Arrange
            int expected = 2520;

            //Act

            int actual = LeastCommonMultiple.LCM(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}