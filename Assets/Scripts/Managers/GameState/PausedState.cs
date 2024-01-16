using UnityEngine;

namespace Managers.GameState
{
    public class PausedState : GameState
    {
        public PausedState(GameContext context) : base(context) {
        }

        public override void EnterState() {
            context.SetState(this);
        }

        public override void UpdateState() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
            }
        }
        
    }
}