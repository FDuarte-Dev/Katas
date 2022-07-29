using FluentAssertions;

namespace Katas.Test.GameOfLife;

public class PositionShould
{
    [Fact]
    public void NotBeAdjacentToSelf()
    {
        var position = new Position(0, 0);

        var result = position.isAdjacentTo(position);
        result.Should().BeFalse();

    }
    
    [Fact]
    public void BeAdjacentToUp()
    {
        var positionAbove = new Position(0, 1);
        var positionBelow = new Position(0, 0);

        var result = positionBelow.isAdjacentTo(positionAbove);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToDown()
    {
        var positionAbove = new Position(0, 1);
        var positionBelow = new Position(0, 0);

        var result = positionAbove.isAdjacentTo(positionBelow);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToLeft()
    {
        var positionRight = new Position(1, 0);
        var positionLeft = new Position(0, 0);

        var result = positionRight.isAdjacentTo(positionLeft);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToRight()
    {
        var positionRight = new Position(1, 0);
        var positionLeft = new Position(0, 0);

        var result = positionLeft.isAdjacentTo(positionRight);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToUpRight()
    {
        var position = new Position(0, 0);
        var positionUpRight = new Position(-1, 1);

        var result = position.isAdjacentTo(positionUpRight);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToUpLeft()
    {
        var position = new Position(0, 0);
        var positionUpLeft = new Position(1, 1);

        var result = position.isAdjacentTo(positionUpLeft);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToDownRight()
    {
        var position = new Position(0, 0);
        var positionDownRight = new Position(-1, -1);

        var result = position.isAdjacentTo(positionDownRight);

        result.Should().BeTrue();
    }
    
    [Fact]
    public void BeAdjacentToDownLeft()
    {
        var position = new Position(0, 0);
        var positionDownLeft = new Position(1, -1);

        var result = position.isAdjacentTo(positionDownLeft);

        result.Should().BeTrue();
    }
}