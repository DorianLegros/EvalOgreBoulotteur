using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    class Girl : Decorator
    {
        private static readonly ISprite sprite = new Sprite('♀');
        public Girl(Proxy child) : base(child)
        {
            
        }

        public override ISprite GetSpriteExtendedDecorated(int num)
        {
            if(num == 1)
            {
                return Girl.sprite;
            }
            return null;
        }
    }
}