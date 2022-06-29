namespace EvalOgreBoulotteur.OgreBoulotteur.Shared
{
    public interface IPawn : ISquare
    {
        int X { get; }
        int Y { get; }
        public IWorld World { get; set; }
        void Live();
        void Die();
        ISprite GetSpriteExtended(int num);
    }
}