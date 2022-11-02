using Microsoft.VisualStudio.TestTools.UnitTesting;
using HabitTracker;

namespace HabitTrackerTests;

[TestClass]
public class ValidationTests
{
    [TestMethod]
    public void WhenQuantityInputIsCorrect()
    {
        var expectedResult = true;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("4");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsNegative()
    {
        var expectedResult = false;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("-4");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsEmpty()
    {
        var expectedResult = false;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsNotNumeric()
    {
        var expectedResult = false;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("blah");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsZero()
    {
        var expectedResult = true;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("0");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsDecimal()
    {
        var expectedResult = true;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("4.5");

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void WhenQuantityInputIsCrazyNumber()
    {
        var expectedResult = false;

        HabitTrackerService habitTrackerService = new();

        var result = habitTrackerService.ValidateQuantityInput("493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432");

        Assert.AreEqual(expectedResult, result);
    }
}