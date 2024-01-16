namespace CharacterUtilities.States
{
    public class IdleState : CharacterState
    {
        public IdleState(Character character) : base(character)
        {
        }

        public override void HandleInput(InputValues inputValues)
        {
            // Handle input for idle state
        }

        public override void Update()
        {
            // Update behavior for idle state
        }
    }
}