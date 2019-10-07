using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common.Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //-- Arrange
            var source = "SonicScrewDriver";
            var expected = "Sonic Screw Driver";


            //-- Act
            var actual = source.InserSpaces();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = source.InserSpaces();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
