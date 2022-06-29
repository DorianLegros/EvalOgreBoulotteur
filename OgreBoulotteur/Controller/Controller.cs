using EvalOgreBoulotteur.OgreBoulotteur.Model.Pawn.Child;
using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Controller
{
    using OgreBoulotteur.Model;
    using OgreBoulotteur.View;

    public class Controller
    {
        private IModel Model { get; set; }
        private IView View { get; set; }

        public Controller()
        {
            Model = new Model();
            View = new View(Model);

            Proxy child1 = new Instrument(new Boy(new Proxy(new StandardChild(14, 1))));
            Proxy child2 = new Girl(new Proxy(new StandardChild(1, 1)));
            Proxy child3 = new Proxy(new StandardChild(10, 1));
            Proxy child4 = new Proxy(new StandardChild(12, 1));
            Model.AddPawn(child1);
            Model.AddPawn(child2);
            Model.AddPawn(child3);
            Model.AddPawn(child4);
        }

        public void GameLoop()
        {
            for (;;)
            {
                View.Show();
                Model.Live();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}