using System;
using NUnit.Framework;

namespace FizzBuzzCore
{
    [TestFixture]
    public class FizzBuzzTest
    {

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(18)]
        public void NumberIsMultipleOfThree(int input)
        {
            String output = FizzBuzz.CheckFizzBuzz(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        [TestCase(5)]
        [TestCase(20)]
        [TestCase(50)]
        public void NumberIsMultipleOfFive(int input)
        {
            String output = FizzBuzz.CheckFizzBuzz(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        [TestCase(5)]
        [TestCase(20)]
        [TestCase(50)]
        public void NumberIsMultipleOfFiveAndThree(int input)
        {
            String output = FizzBuzz.CheckFizzBuzz(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        [TestCase(2)]
        [TestCase(13)]
        [TestCase(17)]
        public void NumberIsNotMultipleOfThreeOrFive(int input)
        {
            String output = FizzBuzz.CheckFizzBuzz(input);
            Assert.AreEqual(input.ToString(), output);
        }
      
    }
}
