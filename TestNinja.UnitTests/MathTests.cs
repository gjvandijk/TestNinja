using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [TearDown]
        public void TearDown()
        {
            _math = null; // not really necessary here
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // arrange
//            var math = new Math();
            // act
            var result = _math.Add(1, 2);
            // assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
        {
//            var math = new Math();
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        {
//            var math = new Math();
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnsSameArgument()
        {
//            var math = new Math();
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));

        }


    }
}
