﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    [TestClass()]
    public class NarcissisticNumberTests
    {
        [TestMethod()]
        public void SampleTests()
        {
            Assert.IsTrue(NarcissisticNumber.Solution(1));
            Assert.IsTrue(NarcissisticNumber.Solution(371));
        }
    }
}