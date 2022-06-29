using System;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Factories;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Square;
using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Factories
{
    public class ThroughableFactory : SquareFactory
    {
        private static ISquare ground = new Ground();
        private static ISquare bridge = new Bridge();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 10);

            if (rand == 0)
            {
                return makeBridge();
            }
            else
            {
                return makeGround();
            }
        }

        private ISquare makeGround()
        {
            return ThroughableFactory.ground;
        }

        private ISquare makeBridge()
        {
            return ThroughableFactory.bridge;
        }
    }
}