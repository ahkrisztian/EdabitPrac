using edabit.SehrSchwer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitTest
{
    public class Working9to5_Test
    {
        [Test]

        public void Check_Working5to9_Result()
        {
            //Arrange
            double expected = 52.5;

            //Act

            double[] TimeArray = new double[] { 13.25, 15, 30, 1.5 };
            double actual = Working.Overtime(TimeArray);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
