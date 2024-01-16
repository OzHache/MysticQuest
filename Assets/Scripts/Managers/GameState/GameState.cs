namespace Managers.GameState
{
    public abstract class GameState
    {
        protected GameContext context;

        public GameState(GameContext context) {
            this.context = context;
        }

        public abstract void EnterState();
        public abstract void UpdateState();
    }
}