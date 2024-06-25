using BowlingInterview;

namespace TestProject1;

public class GameTests
{
    [Fact]
    public void WhenRolling9StrikesAndOn10thFrame0then9ScoreShouldBe258()
    {
        var game = new Game();

        for (var frame = 1; frame <= 9; frame++)
        {
            game.Roll(10);
        }
        
        //10th Frame
        game.Roll(0);
        game.Roll(9);
        
        Assert.Equal(258, game.Score());
    }
    
    [Fact]
    public void WhenRolling9StrikesAndOn10thFrame9then0ScoreShouldBe267()
    {
        var game = new Game();

        for (var frame = 1; frame <= 9; frame++)
        {
            game.Roll(10);
        }
        
        //10th Frame
        game.Roll(9);
        game.Roll(0);
        
        Assert.Equal(267, game.Score());
    }

    [Fact]
    public void WhenRolling12StrikesScoreShouldBe300()
    {
        var game = new Game();

        for (var frame = 1; frame <= 10; frame++)
        {
            game.Roll(10);

            // Your 1st through 9th frame can only have 1 strike.
            // Your 10th frame can have up to 3 strikes.
            if (frame != 10)
            {
                continue;
            }

            game.Roll(10);
            game.Roll(10);
        }
        
        Assert.Equal(300, game.Score());
    }
}