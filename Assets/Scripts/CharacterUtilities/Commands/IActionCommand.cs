namespace CharacterUtilities.Commands
{
    public interface IActionCommand
    {
        public enum CommandType
        {
            Walk, Jump, Idle, Count
        }
        void Execute(InputValues inputValues = default);
        
    }
}