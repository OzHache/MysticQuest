using System.Collections;
using System.Collections.Generic;

namespace Utilities
{
    public class CompositeGameObject : IGameComponent
    {
        private List<IGameComponent> _children = new List<IGameComponent>();

        public void Operation() {
            foreach (var child in _children) {
                child.Operation();
            }
        }

        public void Add(IGameComponent component) {
            _children.Add(component);
        }

        public void Remove(IGameComponent component) {
            _children.Remove(component);
        }

        public IGameComponent GetChild(int index) {
            return _children[index];
        }

        public IEnumerator GetEnumerator()
        {
            return _children.GetEnumerator();
        }
    }
}