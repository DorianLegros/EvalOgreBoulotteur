using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    class Boy : Decorator
    {
        private static readonly ISprite sprite = new Sprite('♂');
        public Boy(Proxy child) : base(child)
        {
            
        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if (num == 1)
            {
                return Boy.sprite;
            }
            return null;
        }
    }
}