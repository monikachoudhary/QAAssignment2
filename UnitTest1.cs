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
}