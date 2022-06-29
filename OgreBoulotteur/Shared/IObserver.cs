namespace EvalOgreBoulotteur.OgreBoulotteur.Shared
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(IOgre ogre);
    }
}