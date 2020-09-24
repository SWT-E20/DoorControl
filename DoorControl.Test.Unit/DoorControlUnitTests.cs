using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

//jenkins test2
namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlUnitTest
    {

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
