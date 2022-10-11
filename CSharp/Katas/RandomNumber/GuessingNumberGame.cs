namespace Katas.RandomNumber;

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
                ? Responses.GUESS_LOWER_THAN_CORRECT 
                : Responses.GUESS_HIGHER_THAN_CORRECT;
        }
        finally
        {
            CurrentGuess++;
        }

        bool IsCorrect() => guessedNumber == CorrectGuess;

        bool IsLastTry() => CurrentGuess == 3;

        bool IsLower() => guessedNumber < CorrectGuess;
    }
}