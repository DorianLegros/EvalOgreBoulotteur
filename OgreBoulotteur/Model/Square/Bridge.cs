namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Square
{
    class Bridge : Square
    {
        private static readonly Sprite sprite = new('=');

        public Bridge() : base(true)
        {
            for (int num = 0; num < 4; num++)
            {
                SetSprite(num, Bridge.sprite);
            }
        }
    }
}