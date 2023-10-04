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
    public void AnalyzeTriangleS1_IsoscelesSides_ReturnsIsosceles()
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
    public void AnalyzeTriangleSide1_ScaleneSides_ReturnsScalene()
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
    public void AnalyzeTriangleSide2_ScaleneSides_ReturnsScalene()
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
    public void AnalyzeTriangleSide3_ScaleneSides_ReturnsScalene()
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
    public void AnalyzeTriangleSide4_ScaleneSides_ReturnsScalene()
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
    public void AnalyzeTriangleSide5_ScaleneSides_ReturnsScalene()
    {
        //Arrange
        int side1 = 8;
        int side2 = 9;
        int side3 = 15;

        //Act
        var result = Triangle.AnalyzeTriangle(side1, side2, side3);

        //Assert
        Assert.AreEqual("A scalene triangle is formed", result);
    }


}