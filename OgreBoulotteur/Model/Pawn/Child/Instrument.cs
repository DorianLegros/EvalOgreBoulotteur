using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    class Instrument : Decorator
    {
        private static readonly ISprite sprite = new Sprite('৳');
        public Instrument(Proxy child) : base(child)
        {

        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if (num == 2)
            {
                return Instrument.sprite;
            }
            return null;
        }
    }
}