using System;
using NUnit.Framework;
using test1_project;
using MySql.Data;
using MySqlConnector;
using System.Collections.Generic;

namespace test1_project.Tests
{
    public class BaseTest
    {
        protected User user;
        //protected Dictionary<string, string> data;
        [SetUp]
        public void Preparation()
        {
            user = new User(new PageProvider());
        }
        [TearDown]
        public void Closing()
        {
            user.pageProvider.Quit();
        }

    }
}
