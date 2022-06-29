using System;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Square;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child
{
    public abstract class Child : Pawn
    {
        public Child(int x, int y) : base(x, y)
        {
        }

        public override void Die()
        {
        }

        public override void Live()
        {
            int newX = X;
            int newY = Y;
            switch (this.GetRandomDirection())
            {
                case 0:
                    newY = Y == 0 ? 0 : Y - 1;
                    break;
                case 1:
                    newX = X == World.Width ? World.Width : X + 1;
                    break;
                case 2:
                    newY = Y == World.Height ? World.Height : Y + 1;
                    break;
                case 3:
                    newX = X == 0 ? 0 : X - 1;
                    break;
            }

            if (World.GetSquare(newX, newY).Throughable)
            {
                X = newX;
                Y = newY;
            }
        }

        private int GetRandomDirection()
        {
            Random random = new();
            return random.Next(0, 4);
        }
    }
}