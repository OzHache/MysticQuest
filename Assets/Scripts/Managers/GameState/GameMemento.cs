namespace Managers.GameState
{
    public class GameMemento
    {
        private string _state;

        public GameMemento(string state) {
            this._state = state;
        }

        public string GetSavedState() {
            return _state;
        }
    }
}