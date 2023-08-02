using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager : IGameService

    {
        IGameValidationService _gameValidationService;

        public GameManager(IGameValidationService gameValidationService)
        {
            _gameValidationService = gameValidationService;
        }

        public void Add(Game game)
        {
            if (_gameValidationService.Validate(game) == true)
            {

                Console.WriteLine("Yeni oyun eklendi");
            }

            else
            {
                Console.WriteLine("Oyun Eklenemedi");
            }
        }

            public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi" + " " + game.GameName + " " + game.GamePrice);
        }

        public void Price(Game game)
        {
            Console.WriteLine("Oyun fiyatı " + " " + game.GameName + " " + game.GamePrice);
        }

        public void Sell(Game game)
        {
            Console.WriteLine("Oyun Satıldı" + "" + game.GameName + "" + game.GamePrice);
        }
    }
}
