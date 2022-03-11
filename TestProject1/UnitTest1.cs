using System;
using System.Collections.Generic;
using NUnit.Framework;
using App1.Models;

namespace TestProject1
{
    public class Tests
    {
        private string _correctUsername = "User1";
        private string _correctPassword = "abc123";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("User1","abc123")]
        [TestCase("User2","abc123")]
        [TestCase("User2","abc1234")]
        [TestCase("User2","abc1231")]
        public void Test1(string username,string password)
        {
            User user = new User();
            user.Username=username;
            user.Password=password;
            Assert.AreEqual(user.Username, _correctUsername);
            Assert.AreEqual(user.Password, _correctPassword);
        }

        [Test]
        public void AddUser()
        {
            var users = new List<User>();
            var initialCount = users.Count;
            users.Add(new User());
            var countAfterAdd = users.Count;
            Assert.AreEqual(initialCount+1, countAfterAdd);
        }

        //Data annotation
        [Test]
        public void TestDivisionByZero()
        {
            Mathematics math = new Mathematics();
            Assert.Throws<DivideByZeroException>(math.Divide);
        }
    }
}