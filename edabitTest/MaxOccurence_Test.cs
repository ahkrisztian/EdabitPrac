using NUnit.Framework;
using edabit.SehrSchwer;

namespace edabitTest
{
    public class MaxOccurence_Test
    {
        [Test]

        public void Search_Maximum_Occurence()
        {
            //Arrange
            string expected = "e";

            //Act

            string actual = MaximumOccurrence.MaxOcc("Computer Science");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
