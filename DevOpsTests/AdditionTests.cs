﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Tests
{
    [TestClass()]
    public class AdditionTests
    {

        

        [TestMethod()]
        public void AdditionalTwoNumbersTest()
        {
            Assert.AreEqual(3 + 4, 8);
        }

        [TestMethod()]
        public void SubtractTwoNumbersTest()
        {
            Assert.AreEqual(7-2, 5);
        }
    }
}