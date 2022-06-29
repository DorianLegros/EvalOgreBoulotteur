using System.Collections.Generic;

namespace EvalOgreBoulotteur.OgreBoulotteur.Shared
{
    using OgreBoulotteur.Model;
    public interface IWorld {
        int Height { get; }
        int Width { get; }
        ISquare GetSquare(int x, int y);
        List<IPawn> GetPawn(int x, int y);
        void LivePawns();
        void AddPawn(IPawn pawn);
        Model Model { get; set; }
    }
}