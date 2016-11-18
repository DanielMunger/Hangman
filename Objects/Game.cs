using System.Collections.Generic;

namespace Hangman.Objects
{
  public class Game
  {
    private string _word;
    private int _incorrectGuesses;
    private bool _gameWin;
    private bool _gameOver;
    private List<int> _correctGuessIndexes = new List<int>{};
    private List<string> _words = new List<string>{};
    private List<string> _lettersGuessed = new List<string>{};

    private static Game _gameState;

    public Game()
    {
      _gameOver = false;
      _gameWin = false;
      _word = "peanut";
      _gameState = this;
    }
    public static Game GetGameState()
    {
      return _gameState;
    }
    public static void SetGameState(Game currentState)
    {
      _gameState = currentState;
    }
    public List<string> GetLettersGuessed()
    {
      return _lettersGuessed;
    }
    public void AddLetterGuessed(string guess)
    {
      _lettersGuessed.Add(guess);
    }

    public string GetWord()
    {
      return _word;
    }
    public bool IsGuessed(string guess)
    {
      bool result = false;
      foreach(string letter in _lettersGuessed)
      {
        if(_lettersGuessed.Contains(guess))
        {
          result = true;
        }
      }
      return result;
    }
    public void CheckLetter(string guess)
    {
      _lettersGuessed.Add(guess);
      if(_word.Contains(guess))
      {
        List<int> indexes = new List<int>{};
        while(_word.Contains(guess))
        {
          int location = _word.IndexOf(guess);
          _word = _word.Remove(location, 1);
          _word = _word.Insert(location, " ");
          indexes.Add(location);
        }
        _correctGuessIndexes = indexes;
      }else
      {
        _incorrectGuesses++;
      }
    }

    public void IncrementIncorrectGuesses()
    {
      _incorrectGuesses++;
    }
    public int GetIncorrectGuesses()
    {
      return _incorrectGuesses;
    }
    public List<int> GetCorrectGuesses()
    {
      return _correctGuessIndexes;
    }
    public void SetGameWin()
    {
      _gameWin = true;
    }
    public bool CheckGameWin()
    {
      return _gameWin;
    }
    public void SetGameOver()
    {
      _gameOver = true;
    }
    public bool CheckGameOver()
    {
      return _gameOver;
    }
  }
}
