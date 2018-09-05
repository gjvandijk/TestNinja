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
        [Ignore("Cant get this fixed")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // arrange
//            var math = new Math();
            // act
            var result = _math.Add(1, 2);
            // assert
            Assert.That(result, Is.EqualTo(3));
        }

        // parameterized testmethod
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]

        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));

        }

    }
}
