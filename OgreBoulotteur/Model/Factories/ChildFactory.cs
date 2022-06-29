using System;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child;
using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Factories
{
    public class ChildFactory : SquareFactory
    {
        private static Random random = new();
        private static StandardChild child = new StandardChild(random.Next(1,15), random.Next(1,59));
        
        public override ISquare makeSquare()
        {
            int rand = random.Next(0, 3);

            switch (rand)
            {
                case 0:
                    return new Instrument(new Boy(new Proxy(new StandardChild(14, 1))));
                break;
                case 1:
                    return new Instrument(new Boy(new Proxy(new StandardChild(14, 1))));
                
            }

            return null;
        }
    }
}