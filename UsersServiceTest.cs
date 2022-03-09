using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitDemo.Services;
using Xunit;
using XUnitDemo.Models;

namespace XUnitDemoTest
{
    public class UsersServiceTest
    {
        //[Theory]
        //[InlineData("Alabatrap123", "Example@123")]
        //[InlineData("Alabatrap1234", "Example@123")]
        //public void LogInSuccessTest(string username, string password)
        //{
        //    var repo = new UserService();
        //    var message = repo.LogIn(username, password);
        //    Assert.True(message);
        //}
        //[Theory]
        //[InlineData("Alabatrap123", "Example@000")]
        ////[InlineData("Alabatrapzz", "Example@000")]
        ////[InlineData("Alabatrapzz", "Example@123")]
        //public void LogInFailTest(string username, string password)
        //{
        //    var repo = new UserService();
        //    var message = repo.LogIn(username, password);
        //    Assert.False(message);
        //}
        //[Theory]
        //[InlineData("Alabatrapzz", "Example@000")]
        //[InlineData("Alabatrapzz", "Example@123")]
        //public void LogInFailThrowExTest(string username, string password)
        //{
        //    var repo = new UserService();
        //    Assert.Throws<KeyNotFoundException>(() => repo.LogIn(username, password));
        //}
        //[Theory]
        //[MemberData(nameof(UserSampleData))]
        //public void LogInMemberDataTest(Users user, bool expected)
        //{
        //    var repo = new UserService();
        //    bool result = repo.LogIn(user.UserName, user.Password);
        //    Assert.Equal(expected, result);
        //}
        //public static IEnumerable<object[]> UserSampleData =>
        //new List<object[]>
        //{
        //    new object[] { 
        //        new Users()
        //        {
        //            UserName = "Alabatrap123",
        //            Password = "Example@123"
        //        }, 
        //        true 
        //    },
        //    new object[] {
        //        new Users()
        //        {
        //            UserName = "Alabatrap123",
        //            Password = "Example@1234"
        //        },
        //        false
        //    }
        //};

        ///*
        // * The length is 8 <= x <= 20
        // * Contain as least 1 UPPER
        // * Contain as least 1 lower
        // * Contain as least 1 digit
        // * Contain as least 1 spec char in this list: @ # ! $ %
        // */
        //[Theory]
        //[InlineData("Example@123")]
        //[InlineData("Ex$12345")]
        //public void PasswordValidTest(string password)
        //{
        //    var repo = new UserService();
        //    var result = repo.IsPasswordValid(password);
        //    Assert.True(result);
        //}
        //[Theory]
        //[InlineData("example")]
        //[InlineData("example123456789abcefgh")]
        //[InlineData("example@123")]
        //[InlineData("EXAMPLE@123")]
        //[InlineData("Example@ott")]
        //[InlineData("Example1234")]
        //public void PasswordInValidTest(string password)
        //{
        //    var repo = new UserService();
        //    var result = repo.IsPasswordValid(password);
        //    Assert.False(result);
        //}
        ///*
        // * The length is 3 <= x <= 20
        // * Contain as least 1 UPPER or lower
        // * Contain as least 1 digit
        // * Allow only underscore char _
        // */
        //[Theory]
        //[InlineData("Example1234")]
        //[InlineData("Example_123")]
        //public void UsernameTest(string username)
        //{
        //    var repo = new UserService();
        //    var result = repo.IsUsernameValid(username);
        //    Assert.True(result);
        //}
        //[Theory]
        //[InlineData("ex")]
        //[InlineData("example123456789abcefghijk")]
        //[InlineData("123456")]
        //[InlineData("EXAMPLEtest")]
        //[InlineData("Example@123")]
        //public void UsernameInValidTest(string username)
        //{
        //    var repo = new UserService();
        //    var result = repo.IsUsernameValid(username);
        //    Assert.False(result);
        //}

        //[Theory]
        //[InlineData("Example_123", "Example@1234")]
        //public void RegisterSuccessTest(string username, string password)
        //{
        //    var repo = new UserService();
        //    var result = repo.Register(username, password);
        //    Assert.True(result);
        //}
        //[Theory]
        //[InlineData("Alabatrap123", "Example@1234")]
        //public void RegisterFailTest(string username, string password)
        //{
        //    var repo = new UserService();
        //    var result = repo.Register(username, password);
        //    Assert.True(result);
        //}
        //[Theory]
        //[InlineData("Alabatrap123")]
        //public void GetSpecifyUserSuccessTest(string username)
        //{
        //    var repo = new UserService();
        //    var user = repo.GetSpecifyUser(username);
        //    Assert.Equal(username, user.UserName);
        //}
        //[Theory]
        //[InlineData("Alabatrap")]
        //public void GetSpecifyUserFailTest(string username)
        //{
        //    var repo = new UserService();
        //    var user = repo.GetSpecifyUser(username);
        //    Assert.Null(user);
        //}
    }
}
