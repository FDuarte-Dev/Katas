namespace Katas.RandomNumber;

public class GuessingNumberGame: IGuessingNumberGame
{
    private int CorrectGuess { get; }
    
    public GuessingNumberGame(RandomNumberGenerator generator)
    {
        CorrectGuess = generator.GetInt();
    }

    public string GuessNumber(int guessedNumber)
    {
        if (IsLower())
        {
            return Responses.GUESS_LOWER_THAN_CORRECT;
        }

        if (IsHigher())
        {
            return Responses.GUESS_HIGHER_THAN_CORRECT;
        }
        
        return Responses.CORRECT_GUESS;

        bool IsLower()
        {
            return guessedNumber < CorrectGuess;
        }

        bool IsHigher()
        {
            return guessedNumber > CorrectGuess;
        }
    }
}