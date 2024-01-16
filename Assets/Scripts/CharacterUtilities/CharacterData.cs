using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

namespace CharacterUtilities
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Character Data", order = 51)]
    public class CharacterData : ScriptableObject
    {
        [Header("Character Data")]
        [SerializeField] private string characterName;
        [SerializeField] private int maxHealth;
        [SerializeField] private int health;
        [SerializeField] private int speed;
        [SerializeField] private int jumpForce;
        [Header("Sprite Data")]
        [SerializeField] private Sprite sprite;
        [SerializeField] private AnimatorController animator;
        //inventory
        [SerializeField]List<Progress.Item> inventory = new List<Progress.Item>();
        //Getters
        public string GetCharacterName => characterName;
        public int GetMaxHealth => maxHealth;
        public int GetHealth => health;
        public int GetSpeed => speed;
        public int GetJumpForce => jumpForce;
        public Sprite GetSprite => sprite;
        public AnimatorController GetAnimator => animator;
        public List<Progress.Item> GetInventory => inventory;
        //Setters
        public void SetCharacterName(string name) => characterName = name;
        public void SetMaxHealth(int max) => maxHealth = max;
        public void SetHealth(int health) => this.health = health;
        public void SetSpeed(int speed) => this.speed = speed;
        public void SetJumpForce(int jumpForce) => this.jumpForce = jumpForce;
        public void SetSprite(Sprite sprite) => this.sprite = sprite;
        public void SetAnimator(AnimatorController animator) => this.animator = animator;
        public void SetInventory(List<Progress.Item> inventory) => this.inventory = inventory;
    }
}
