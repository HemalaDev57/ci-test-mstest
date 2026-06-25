using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TestAddNumbers() { Assert.AreEqual(5, 2 + 3); }

    [TestMethod]
    public void TestSubtractNumbers() { Assert.AreEqual(1, 3 - 2); }

    [TestMethod]
    public void TestSubtractNumbers_FailsWhenNegative() { Assert.AreEqual(0, 5 - 9); } // deliberate fail

    [TestMethod]
    [Ignore("Not implemented yet")]
    public void TestMultiplyByZero() { Assert.AreEqual(0, 5 * 0); }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestDivideByZero() { int zero = 0; int x = 1 / zero; }
}
