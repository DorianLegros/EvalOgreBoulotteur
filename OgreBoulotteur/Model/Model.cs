using System.Collections.Generic;
using EvalOgreBoulotteur.OgreBoulotteur.Model.Factories;
using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model
{
    public class Model : IModel {
        private IWorld World { get; set; }

        public int Height { get { return World.Height; } }
        public int Width { get { return World.Width; } }

        public ThroughableFactory ThroughableFactory { get; private set; }
        public NotThroughableFactory NotThroughableFactory { get; private set; }
        Model IWorld.Model { get; set; }

        public Model() {
            NotThroughableFactory = new NotThroughableFactory();
            ThroughableFactory = new ThroughableFactory();
            World = new World(15, 59, 10, this);
        }

        public ISquare GetSquare(int x, int y) {
            return World.GetSquare(x, y);
        }

        public List<IPawn> GetPawn(int x, int y) {
            return World.GetPawn(x, y);
        }

        public void Live() {
            LivePawns();
        }

        public void LivePawns() {
            World.LivePawns();
        }

        public void AddPawn(IPawn pawn) {
            World.AddPawn(pawn);
        }
    }
}