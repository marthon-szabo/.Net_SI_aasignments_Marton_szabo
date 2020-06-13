using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using NUnit.Framework;
using RegEx;
using Assert = NUnit.Framework.Assert;

namespace RegExUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
      

        [TestCase("+36304563248", true)]
        [TestCase("06302315643", true)]
        [TestCase("2",false)]
        [TestCase("a", false)]
        public void TestPhoneValidator(string phone, bool expected)
        {
            User _user = new User();
            bool _actual;

            //act
            _actual = _user.CheckPhone(phone);

            //assert
            Assert.AreEqual(expected, _actual);
        }
    }
}
