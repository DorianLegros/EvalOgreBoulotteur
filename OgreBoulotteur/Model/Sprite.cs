using EvalOgreBoulotteur.OgreBoulotteur.Shared;

namespace EvalOgreBoulotteur.OgreBoulotteur.Model
{
    class Sprite : ISprite {


        public char Character { get; set; }

        public Sprite(char character) {
            this.Character = character;
        }

    }
}