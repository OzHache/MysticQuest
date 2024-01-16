using CharacterUtilities.States;

namespace CharacterUtilities.Commands
{
    public class JumpActionCommand : IActionCommand {
        private Character _character;

        public JumpActionCommand(Character character) {
            this._character = character;
        }

        public void Execute(InputValues inputValues = default) {
            var state = _character.SetState(new JumpingState(_character));
            state.HandleInput(inputValues);
        }
    }
}