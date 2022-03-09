using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitDemo.Services;

namespace XUnitDemoTest
{
    public class UsernamePasswordTest
    {
        /*
         * The length is 8 <= x <= 20
         * Contain as least 1 UPPER
         * Contain as least 1 lower
         * Contain as least 1 digit
         * Contain as least 1 spec char in this list: @ # ! $ %
         */
        [Theory]
        [InlineData("example", false)]
        [InlineData("example123456789abcefgh", false)]
        [InlineData("example@123", false)]
        [InlineData("EXAMPLE@123", false)]
        [InlineData("Example@ott", false)]
        [InlineData("Example1234", false)]
        [InlineData("Example@123", true)]
        public void PasswordTest(string password, bool expected)
        {
            var repo = new UserService();
            var result = repo.IsPasswordValid(password);
            Assert.Equal(expected, result);
        }
        
        /*
         * The length is 3 <= x <= 20
         * Contain as least 1 UPPER or lower
         * Contain as least 1 digit
         * Allow only underscore char _
         */
        [Theory]
        [InlineData("ex", false)]
        [InlineData("example123456789abcefghijk", false)]
        [InlineData("123456", false)]
        [InlineData("EXAMPLEtest", false)]
        [InlineData("Example@123", false)]
        [InlineData("Example1234", true)]
        [InlineData("Example_123", true)]
        public void UsernameTest(string username, bool expected)
        {
            var repo = new UserService();
            var result = repo.IsUsernameValid(username);
            Assert.Equal(expected, result);
        }
    }
}
