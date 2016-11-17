using System.Collections.Generic;

namespace Hangman.Objects
{
  public class Player
  {
    private List<string> _lettersGuessed = new List<string>{};

    public Player()
    {

    }
    public List<string> GetLettersGuessed()
    {
      return _lettersGuessed;
    }
    public void AddLetterGuessed(string guess)
    {
      _lettersGuessed.Add(guess);
    }
  }
}
