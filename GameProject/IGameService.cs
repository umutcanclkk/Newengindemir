using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
     interface IGameService
    {
        void Add(Game game);

        void Price(Game game);

        void Delete(Game game);

        void Sell(Game game);

    }
}
