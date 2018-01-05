using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace FizzBuzzServiceLibrary
{
    [TestFixture]
    class Testing
    {
        [Test]
        public void checkResult() {
            FizzBuzz fizzbuzz2 = new FizzBuzz(2);
            FizzBuzz fizzbuzz3 = new FizzBuzz(3);
            FizzBuzz fizzbuzz5 = new FizzBuzz(5);
            FizzBuzz fizzbuzz15 = new FizzBuzz(15);

            Assert.AreEqual(fizzbuzz2.getResponse(), "2");
            Assert.AreEqual(fizzbuzz3.getResponse(), "Fizz");
            Assert.AreEqual(fizzbuzz5.getResponse(), "Buzz");
            Assert.AreEqual(fizzbuzz15.getResponse(), "FizzBuzz");
        }


    }
}
