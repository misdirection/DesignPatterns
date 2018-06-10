using System;

namespace Decorator_Pattern
{
    public class EvenBetterDLC : DlcDecorator
    {
        private DungieGame _dungieGame;

        public EvenBetterDLC(DungieGame dungieGame) => _dungieGame = dungieGame;
        public override string Description => _dungieGame.Description + "\nEven better DLC, we rly need money plz!";
        public override double Price => 29.99d+ _dungieGame.Price;
    }
}
