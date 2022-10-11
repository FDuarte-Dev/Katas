namespace Katas.RandomNumber;

public class GuessingNumberGame: IGuessingNumberGame
{
    public int CorrectGuess { get; }
    
    public GuessingNumberGame(RandomNumberGenerator generator)
    {
        this.CorrectGuess = generator.GetInt();
    }

    public string GuessNumber(int guessedNumber)
    {
        if (guessedNumber < CorrectGuess)
        {
            return Responses.GUESS_LOWER_THAN_CORRECT;
        }
        
        return Responses.CORRECT_GUESS;
    }
}