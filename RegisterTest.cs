using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitDemo.Models;
using XUnitDemo.Services;

namespace XUnitDemoTest
{
    public class RegisterTest
    {
        [Theory]
        [InlineData("Example_1234", "Example@1234")]
        public void RegisterSuccessTest(string username, string password)
        {
            var repo = new UserService();
            var result = repo.Register(username, password);
            Assert.True(result);
        }
        [Theory]
        [InlineData("Alabatrap123", "Example@1234")]
        public void RegisterFailTest(string username, string password)
        {
            var repo = new UserService();
            Assert.Throws<Exception>(() => repo.Register(username, password));
        }
    }
}
