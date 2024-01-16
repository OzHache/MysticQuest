namespace Managers.GameState
{
    public class GameContext
    {
        private GameState _currentState;
        private string _stateInfo; // Information representing the current state

        public void SetState(GameState state) {
            _currentState = state;
            _currentState.EnterState();
        }

        public GameMemento SaveToMemento() {
            return new GameMemento(_stateInfo);
        }

        public void RestoreFromMemento(GameMemento memento) {
            _stateInfo = memento.GetSavedState();
            // Restore the state based on stateInfo
        }
        public void UpdateState() {
            _currentState.UpdateState();
        }

        // Other context methods...
    }
}