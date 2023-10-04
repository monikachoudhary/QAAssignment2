using NUnit.Framework.Internal;

namespace TriangleSolver.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void AnalyzeTriangle_EquilateralSides_ReturnsEquilateral()
    {
        //Arrange
        int side1 = 5;
        int side2 = 5;
        int side3 = 5;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("An equilateral triangle is formed", result);
    }


    [Test]
    public void AnalyzeTriangleSide1_IsoscelesSides_ReturnsIsosceles()
    {
        //Arrange
        int side1 = 4;
        int side2 = 5;
        int side3 = 5;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("An isosceles triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangleSide2_IsoscelesSides_ReturnsIsosceles()
    {
        //Arrange
        int side1 = 5;
        int side2 = 4;
        int side3 = 5;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("An isosceles triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangleSide3_IsoscelesSides_ReturnsIsosceles()
    {
        //Arrange
        int side1 = 5;
        int side2 = 5;
        int side3 = 4;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("An isosceles triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangle_ScaleneSides1_ReturnsScalene()
    {
        //Arrange
        int side1 = 3;
        int side2 = 4;
        int side3 = 5;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangle_ScaleneSides2_ReturnsScalene()
    {
        //Arrange
        int side1 = 7;
        int side2 = 24;
        int side3 = 25;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangle_ScaleneSides3_ReturnsScalene()
    {
        //Arrange
        int side1 = 8;
        int side2 = 15;
        int side3 = 17;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }
    [Test]
    public void AnalyzeTriangle_ScaleneSides4_ReturnsScalene()
    {
        //Arrange
        int side1 = 5;
        int side2 = 12;
        int side3 = 13;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangle_ScaleneSides5_ReturnsScalene()
    {
        //Arrange
        int side1 = 9;
        int side2 = 40;
        int side3 = 41;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }

    [Test]
    public void AnalyzeTriangle_OneSideWithZeroLength_ReturnsInvalid()
    {
        // Arrange
        int side1 = 0;
        int side2 = 4;
        int side3 = 5;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("At least one side entered had a zero - invalid triangle", result);
    }

    [Test]
    public void AnalyzeTriangle_TwoSidesWithZeroLength_ReturnsInvalid()
    {
        // Arrange
        int side1 = 0;
        int side2 = 0;
        int side3 = 3;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("At least one side entered had a zero - invalid triangle", result);
    }

    [Test]
    public void AnalyzeTriangle_AllThreeSidesWithZeroLength_ReturnsInvalid()
    {
        // Arrange
        int side1 = 0;
        int side2 = 0;
        int side3 = 0;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("At least one side entered had a zero - invalid triangle", result);
    }


    [Test]
    public void AnalyzeTriangle_NegativeSideLength_ReturnsInvalid()
    {
        // Arrange
        int side1 = 3;
        int side2 = 4;
        int side3 = -5;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("A triangle cannot be formed", result);
    }

    [Test]
    public void AnalyzeTriangle_SumOfTwoSidesLessThanThird_ReturnsInvalid()
    {
        // Arrange
        int side1 = 2;
        int side2 = 3;
        int side3 = 6;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("A triangle cannot be formed", result);
    }

    [Test]
    public void AnalyzeTriangle_SumOfTwoSidesEqualToThird_ReturnsInvalid()
    {
        // Arrange
        int side1 = 3;
        int side2 = 3;
        int side3 = 6;

        // Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        // Assert
        Assert.AreEqual("A triangle cannot be formed", result);
    }

}