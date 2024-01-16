using UnityEngine;

namespace CharacterUtilities.Features
{
    public class WeaponFeature : CharacterFeature
    {
        public override void ApplyFeature() {
            // Logic to apply weapon feature
            Debug.Log("Weapon added to character.");
        }
        public override void RemoveFeature() {
            // Logic to remove weapon feature
            Debug.Log("Weapon removed from character.");
        }
    }
}