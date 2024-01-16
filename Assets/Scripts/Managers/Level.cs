using UnityEngine;
using Utilities;

namespace Managers
{
    public class Level : MonoBehaviour
    {
        private CompositeGameObject _levelRoot;

        void Start() {
            _levelRoot = new CompositeGameObject();
            // Construct the level hierarchy by adding components
        }

        void Update() {
            GameComponentIterator iterator = new GameComponentIterator(_levelRoot);
            while (iterator.HasNext()) {
                IGameComponent component = iterator.Next();
                component.Operation(); // Perform an operation like update or render
            }
        }
    }
}