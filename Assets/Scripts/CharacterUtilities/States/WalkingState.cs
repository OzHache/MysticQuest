using UnityEngine;

namespace CharacterUtilities.States
{
    public class WalkingState : CharacterState {
        private CharacterMovement2D _characterMovement2D;
        private Vector2 movement;
        public WalkingState(Character character) : base(character)
        {
            _characterMovement2D = character.GetComponent<CharacterMovement2D>();

        }
        

        public override void HandleInput(InputValues inputValues) {
            movement.x = inputValues.Horizontal;
            movement.y = inputValues.Vertical;
        }

        public override void Update() {
            // Update behavior for walking state
            _characterMovement2D.Move(movement.x, movement.y);
        }
        
    }
}