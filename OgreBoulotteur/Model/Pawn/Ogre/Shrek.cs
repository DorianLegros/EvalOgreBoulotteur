using System;
using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn
{
    public class Shrek : Ogre
    {
        private static readonly Sprite sprite = new('S');

        public Shrek(int x, int y) : base(x, y)
        {
            this.SetSprite(0, sprite);
            this.SetSprite(1, sprite);
            this.SetSprite(2, sprite);
            this.SetSprite(3, sprite);
        }

        public override ISprite GetSpriteExtended(int num)
        {
            return null;
        }
    }
}