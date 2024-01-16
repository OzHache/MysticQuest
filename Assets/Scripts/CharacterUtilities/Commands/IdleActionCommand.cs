using CharacterUtilities.States;

namespace CharacterUtilities.Commands
{
    public class IdleActionCommand: IActionCommand
    {
        private Character _character;

        public IdleActionCommand(Character character)
        {
            this._character = character;
        }

        public void Execute(InputValues inputValues = default)
        {
            _character.SetState(new IdleState(_character));
        }
        
    }
}