namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn
{
    public class Pawn
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        protected Pawn(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}