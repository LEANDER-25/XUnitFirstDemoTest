using System;
using Xunit;
using XUnitDemo;

namespace XUnitDemoTest
{
    public class DoTheMathTest
    {
        [Fact]
        public void AddTwoNumbersTest()
        {
            //arrange - setup
            /*
             * This is a SETUP step
             * In this step, what you need to do are prepare everything 
             *   which your target you want to test need
             */
            int a = 5;
            int b = 5;

            //act - trigger
            /*
             * This is an action - trigger step
             * In this step, what you need to do is call to your target
             */
            var result = DoTheMath.AddTwoNumbers(a, b);
            //assert - PASS or FAIL
            /*
             * This is an last step
             * In this step, you will set up your expect value 
             *   to compare to your target return value
             */
            Assert.Equal(10, result);//true -> pass; false -> fail
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1.5, 2.5, 4)]
        [InlineData(-10, 10, 0)]
        [InlineData(-10, -10, -20)]
        [InlineData(15, -10, 5)]
        public void AddTwoNumbersWithTheory(double a, double b, double expected)
        {
            var result = DoTheMath.AddTwoNumbers(a, b);
            Assert.Equal(expected, result);
        }
    }
}
