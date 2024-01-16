using System.Collections;

namespace Utilities
{
    public interface IGameComponent : IEnumerable
    {
        void Operation();
        void Add(IGameComponent component);
        void Remove(IGameComponent component);
        IGameComponent GetChild(int index);
    }
}