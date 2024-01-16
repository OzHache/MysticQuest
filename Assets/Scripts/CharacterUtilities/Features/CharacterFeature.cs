using UnityEngine;

namespace CharacterUtilities.Features
{
    public abstract class CharacterFeature : MonoBehaviour {
        public abstract void ApplyFeature();
        public abstract void RemoveFeature();
    }
}