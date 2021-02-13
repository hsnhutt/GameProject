using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " game is on sale! PRICE: " + game.GamePrice + "$");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " price updated! NEW PRICE: " + game.GamePrice + "$");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " the game is no longer sold.");
        }
    }
}
