namespace Katalyst.RandomNumber;

public class GuessingNumberGame: IGuessingNumberGame
{
    private int CorrectGuess { get; }
    public int CurrentGuess { get; set; }
    
    public GuessingNumberGame(RandomNumberGenerator generator)
    {
        CorrectGuess = generator.GetInt();
        CurrentGuess = 1;
    }

    public string GuessNumber(int guessedNumber)
    {
        try
        {
            if (IsCorrect())
            {
                return Responses.CORRECT_GUESS;
            }

            if (IsLastTry())
            {
                return Responses.YOU_LOSE;
            }
            
            return IsLower() 
                ? Responses.CORRECT_LOWER_THAN_GUESS 
                : Responses.CORRECT_HIGHER_THAN_GUESS;
        }
        finally
        {
            CurrentGuess++;
        }

        bool IsCorrect() => guessedNumber == CorrectGuess;

        bool IsLastTry() => CurrentGuess == 3;

        bool IsLower() => CorrectGuess < guessedNumber;
    }
}