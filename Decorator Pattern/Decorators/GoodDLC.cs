using System;

namespace Decorator_Pattern
{
    public class GoodDLC : DlcDecorator
    {
        private DungieGame _dungieGame;

        public GoodDLC(DungieGame dungieGame) => _dungieGame = dungieGame;
        public override string Description => _dungieGame.Description + "\nVery good DLC, plz buy and give us money!";
        public override double Price => 19.99d + _dungieGame.Price;
    }
}
