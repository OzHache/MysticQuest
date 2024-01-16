using UnityEngine;

namespace CharacterUtilities.Features
{
    public class ArmourFeature : CharacterFeature
    {
        public override void ApplyFeature()
        {
            // Logic to apply armor feature
            Debug.Log("Armor added to character.");
        }
        public override void RemoveFeature()
        {
            // Logic to remove armor feature
            Debug.Log("Armor removed from character.");
        }
    }
}