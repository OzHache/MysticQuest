namespace CharacterUtilities.States
{
    public class JumpingState : CharacterState {
        private CharacterMovement2D _characterMovement2D;
        private bool jump;
        public JumpingState(Character character) : base(character)
        {
            _characterMovement2D = character.GetComponent<CharacterMovement2D>();
        }

        public override void HandleInput(InputValues inputValues) {
            // Handle input for jumping state
            jump = inputValues.Jump;
        }

        public override void Update() {
            // Update behavior for jumping state
            if (jump)
                _characterMovement2D.Jump();
        }
    }
}