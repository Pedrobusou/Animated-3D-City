using NUnit.Framework;

public class PointCalculatorTest
{
    [Test]
    public void CalculateTotalPoints_Test()
    {
        // Arrange
        var pointCalculator = new PointCalculator();
        var killedEnemies = 24;
        var killedVillagers = 3;
        var multiplicator = 2;
        var expectedPoints = (24 * 100 + 2 * 500 - 3 * 100) * 2;

        // Act
        var points = pointCalculator.CalculateTotalPoints(killedEnemies, killedVillagers, multiplicator);

        // Assert
        Assert.That(points, Is.EqualTo(expectedPoints));
    }
}
