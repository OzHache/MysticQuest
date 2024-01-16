using System.Collections.Generic;

namespace Utilities
{
    public class GameComponentIterator
    {
        private CompositeGameObject _root;
        private Stack<IGameComponent> _stack = new Stack<IGameComponent>();

        public GameComponentIterator(CompositeGameObject root) {
            this._root = root;
            _stack.Push(root);
        }

        public bool HasNext() {
            return _stack.Count > 0;
        }

        public IGameComponent Next() {
            var current = _stack.Pop();
            foreach (IGameComponent child in current)
            {
                _stack.Push(child);
            }
            return current;
        }
    }
}