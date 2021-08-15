using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edabit.Schwer;
using NUnit.Framework;

namespace edabitTest
{
    public class Swapping_Test
    {
        [Test]
        public void Search_Swapping_Result()
        {
            //Arrange
            string expected = "A";

            //Act

            string actual = Swapping.cupSwapping("BA", "AC", "CA", "BC");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
