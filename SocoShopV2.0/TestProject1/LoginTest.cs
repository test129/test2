﻿using SocoShop.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocoShop.Entity;

namespace TestProject1
{
    
    
    /// <summary>
    ///这是 LoginTest 的测试类，旨在
    ///包含所有 LoginTest 单元测试
    ///</summary>
    [TestClass()]
    public class LoginTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///PostBack 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PostBackTest()
        {
            Login_Accessor target = new Login_Accessor(); // TODO: 初始化为适当的值
            target.PostBack();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///checklogin 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void checkloginTest()
        {
            Login_Accessor target = new Login_Accessor(); // TODO: 初始化为适当的值
            string logname = "aaa"; // TODO: 初始化为适当的值
            string loginpass = "1234567"; // TODO: 初始化为适当的值
            UserInfo expected = null; // TODO: 初始化为适当的值
            UserInfo actual;
            actual = target.checklogin(logname, loginpass);
           // Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.ID >0);
           // Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
