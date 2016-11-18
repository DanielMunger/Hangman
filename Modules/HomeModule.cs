using Nancy;
using System.Collections.Generic;
using Hangman.Objects;

namespace Hangman
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Get["/game"] = _ =>
      {
        Game newGame = new Game();
        return View["game.cshtml", newGame];
      };
      Post["/game"] = _ =>
      {
        Game game = Game.GetGameState();
        string guess = Request.Form["guess"];
        if(!game.IsGuessed(guess))
        {
          game.CheckLetter(guess);
        }
        Game.SetGameState(game);
        return View["game.cshtml", game];
      };

    }
  }
}
