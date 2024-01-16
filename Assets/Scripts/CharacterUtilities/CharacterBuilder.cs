using Unity.VisualScripting;
using UnityEngine;

namespace CharacterUtilities
{
    public class CharacterBuilder {
        
        private Character _character = new GameObject("Character").AddComponent<Character>();
        
        public CharacterBuilder WithArmor(string armorType) {
            _character.armor = armorType;
            return this;
        }

        public CharacterBuilder WithWeapon(string weaponType) {
            _character.weapon = weaponType;
            return this;
        }

        public CharacterBuilder WithPower(int powerLevel) {
            _character.powerLevel = powerLevel;
            return this;
        }

        public Character Build(CharacterData characterData) {
            _character.Initialize(characterData);
            _character.gameObject.AddComponent<CharacterMovement2D>().Initialize(characterData);
            //Set Sprite and Animator
            _character.gameObject.AddComponent<SpriteRenderer>().sprite = characterData.GetSprite;
            _character.gameObject.AddComponent<Animator>().runtimeAnimatorController = characterData.GetAnimator;
            //set the order in layer 
            _character.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            return _character;
        }
    }
}