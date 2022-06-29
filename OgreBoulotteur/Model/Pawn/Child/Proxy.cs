using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    public class Proxy : IPawn
    {
        public Child child { get; }

        public Proxy(Child child)
        {
            this.child = child;
        }

        public int X => child.X;

        public int Y => child.Y;

        public IWorld World { get => child.World; set => child.World = value; }

        public ISprite Sprite => child.Sprite;

        public bool Throughable => child.Throughable;

        public void Die()
        {
            child.Die();
        }

        public virtual ISprite GetSprite(int num)
        {
            return child.GetSprite(num);
        }

        public void SetSprite(int num, ISprite sprite)
        {
            child.SetSprite(num, sprite);
        }

        public void Live()
        {
            child.Live();
        }

        public virtual ISprite GetSpriteExtended(int num)
        {
            return child.GetSpriteExtended(num);
        }
    }
}