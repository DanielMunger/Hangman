using System.Collections.Generic;

namespace Hangman.Objects
{
  public class Game
  {
    private string _word;
    private int _incorrectGuesses;
    private bool _gameWin;
    private bool _gameOver;

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
    public void IncrementIncorrectGuesses()
    {
      _incorrectGuesses++;
    }
    public int GetIncorrectGuesses()
    {
      return _incorrectGuesses;
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
