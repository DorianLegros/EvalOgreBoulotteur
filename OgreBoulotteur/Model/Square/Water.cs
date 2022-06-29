namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Square
{
    class Water : Square
    {
        private static readonly Sprite sprite = new('#');

        public Water() : base(false)
        {
            for (int num = 0; num < 4; num++)
            {
                SetSprite(num, Water.sprite);
            }
        }
    }
}