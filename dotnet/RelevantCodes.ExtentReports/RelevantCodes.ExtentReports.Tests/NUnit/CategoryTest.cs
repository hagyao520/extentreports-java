﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Tests.Common;

namespace RelevantCodes.ExtentReports.Tests.NUnit
{
    [TestFixture]
    public class CategoryTest : ExtentBase
    {
        [Test]
        public void SingleCategory()
        {
            test = extent
                .StartTest("SingleCategory")
                .AssignCategory("Extent");
            test.Log(LogStatus.Pass, "Details");

            Assert.True(test.GetTest().CategoryList.Count == 1);
        }

        [Test]
        public void ManyCategories()
        {
            test = extent
                .StartTest("ManyCategories")
                .AssignCategory("Extent", "Regression", "Smoke", "HelloWorld");
            test.Log(LogStatus.Pass, "Details");

            Assert.True(test.GetTest().CategoryList.Count == 4);
        }
    }
}