using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Square
{
    public abstract class Square : ISquare
    {
        public ISprite Sprite { get; private set; }
        private readonly ISprite[] sprites;

        public bool Throughable { get; private set; }

        protected Square(bool throughable)
        {
            Throughable = throughable;
            this.sprites = new ISprite[4];
        }

        public ISprite GetSprite(int num)
        {
            return this.sprites[num];
        }
        public abstract ISprite GetSpriteExtended(int num);
        public void SetSprite(int num, ISprite sprite)
        {
            this.sprites[num] = sprite;
        }
    }
}