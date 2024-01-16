using System;
using CharacterUtilities.States;
using UnityEngine;

namespace CharacterUtilities
{
    [System.Serializable]
    public class Character : MonoBehaviour, ICloneable {
        private CharacterState _currentState;
        public string armor;
        public string weapon;
        public int powerLevel;
        //Character Data Features
        private string _name;
        private int _maxHealth;
        private int _health;
        
        public void Initialize ( CharacterData characterData ) {
            _name = characterData.GetCharacterName;
            _maxHealth = characterData.GetMaxHealth;
            _health = characterData.GetHealth;
        }
        
        public object Clone() {
            return this.MemberwiseClone(); // Shallow copy for prototype pattern
        }
        void Start() {
            SetState(new IdleState(this));
        }

        void Update() {
            _currentState.Update();
        }

        public CharacterState SetState(CharacterState state) {
            return _currentState = state;
        }

        // Additional methods for character behavior can be added here
        
    }
}