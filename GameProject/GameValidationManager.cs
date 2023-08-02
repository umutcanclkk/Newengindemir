using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameValidationManager : IGameValidationService
    {
        public bool Validate(Game game)
        {
            if (game.Id == 1 && game.GameName == "Counter Strike" && game.GamePrice == 15)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

