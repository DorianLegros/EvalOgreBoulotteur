using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    abstract class Decorator : Proxy
    {
        protected Proxy ProxyChild { get; set; }
        protected Decorator(Proxy child) : base(child.child)
        {
            ProxyChild = child;
        }

        public override ISprite GetSprite(int num)
        {
            ISprite result = GetSpriteExtended(num);
            if (result != null)
            {
                return result;
            }
            return this.ProxyChild.GetSprite(num);
        }

        public override ISprite GetSpriteExtended(int num)
        {
            ISprite result;
            result = this.GetSpriteExtendedDecorated(num);
            if(result != null)
            {
                return result;
            }
            return this.ProxyChild.GetSpriteExtended(num);
        }

        public abstract ISprite GetSpriteExtendedDecorated(int num);
    }
}