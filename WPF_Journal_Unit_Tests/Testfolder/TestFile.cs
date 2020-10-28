using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WPF_Login;

namespace WPF_Journal_Unit_Tests.Testfolder
{
    [TestFixture]
    public class TestFile
    {
        [Test]
        public void MethodName_ScenarioDescription()
        {
            // Arrange
            int x = 6;
            int y = 1;
            int expectedValue = 7;
            MethodsForUnitTests test = new MethodsForUnitTests();

            // Act
            int result = test.SumSomething(x, y);

            // Assert
            Assert.AreEqual(expectedValue, result);

        }
    }
}
