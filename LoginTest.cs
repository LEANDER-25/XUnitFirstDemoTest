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
    public class LoginTest
    {
        [Theory]
        [InlineData("Alabatrap123", "Example@123")]
        [InlineData("Alabatrap1234", "Example@123")]
        public void LogInSuccessTest(string username, string password)
        {
            var repo = new UserService();
            var message = repo.LogIn(username, password);
            Assert.True(message);
        }

        [Theory]
        [InlineData("Alabatrap123", "Example@000")]
        [InlineData("Alabatrap1234", "Example@000")]
        public void LogInFailTest(string username, string password)
        {
            var repo = new UserService();
            var message = repo.LogIn(username, password);
            Assert.False(message);
        }

        [Theory]
        [InlineData("Alabatrapzz", "Example@000")]
        public void LogInFailThrowExTest(string username, string password)
        {
            var repo = new UserService();
            Assert.Throws<KeyNotFoundException>(() => repo.LogIn(username, password));
        }
        //229c7501fb77f2b570cb3d402f35b84f - Example@123
    }
}
