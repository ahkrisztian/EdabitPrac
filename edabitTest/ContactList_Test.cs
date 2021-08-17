using edabit.SehrSchwer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitTest
{
    public class ContactList_Test
    {
        [Test]
        public void Check_Desc_Result()
        {
            //Arrange
            string[] expected = new string[] { "Carl Gauss", "Leonhard Euler", "Paul Erdos" };

            //Act

            string[] listofnames = new string[] { "Paul Erdos", "Leonhard Euler", "Carl Gauss" };

            string[] actual = ContactList.AscOrder(listofnames, "DESC");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Check_Asc_Result()
        {
            //Arrange
            string[] expected = new string[] { "Thomas Aquinas","Rene Descartes","David Hume","John Locke" };

            //Act

            string[] listofnames = new string[] { "John Locke","Thomas Aquinas","David Hume","Rene Descartes" };

            string[] actual = ContactList.AscOrder(listofnames, "ASC");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
