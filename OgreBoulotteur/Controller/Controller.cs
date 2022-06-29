using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Controller
{
    using OgreBoulotteur.Model;
    using OgreBoulotteur.View;
    public class Controller
    {
        private IModel Model { get; set; }
        private IView View { get; set; }
        
        public Controller() {
            Model = new Model();
            View = new View(Model);
        }
        
        public void GameLoop() {
            for (;;) {
                View.Show();
                Model.Live();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    
    
}