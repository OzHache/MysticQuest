namespace CharacterUtilities.States
{
    public abstract class CharacterState {
        protected Character Character;

        public CharacterState(Character character) {
            this.Character = character;
        }

        public abstract void HandleInput(InputValues inputValues); // Handle input in each state
        public abstract void Update();      // Update state behavior
    }
}