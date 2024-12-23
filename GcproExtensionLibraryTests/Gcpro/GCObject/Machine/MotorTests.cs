using Microsoft.VisualStudio.TestTools.UnitTesting;
using GcproExtensionLibrary.Gcpro.GCObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GcproExtensionLibrary.Gcpro.GCObject.Tests
{
    [TestClass()]
 
    public class MotorTests
    {
        [TestMethod]
        [Timeout(100)]  // Milliseconds
        public void TestStartingTime()
        {
            // arrange
            int expected = 3;
            int actual = 0;
            var motor = new Motor();

            // act
            actual = Motor.GetStartingTime(0.37);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}