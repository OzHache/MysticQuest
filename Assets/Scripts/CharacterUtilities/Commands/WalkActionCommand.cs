using CharacterUtilities.States;

namespace CharacterUtilities.Commands
{
    public class WalkActionCommand : IActionCommand
    {
        private Character _character;

        public WalkActionCommand(Character character)
        {
            this._character = character;
        }

        public void Execute(InputValues inputValues = default)
        {
            var state = _character.SetState(new WalkingState(_character));
            state.HandleInput(inputValues);
            //Additional logic for walking action command can be added here such as animation triggers, sounds, etc.
        }
        
    }
}