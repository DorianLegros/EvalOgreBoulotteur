namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Square
{
    class Rock  : Square {
        private static readonly Sprite sprite = new('░');
        public Rock() : base( false) {
        }
    }
}