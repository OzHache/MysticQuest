using CharacterUtilities;
using CharacterUtilities.Commands;
using CharacterUtilities.Features;
using CharacterUtilities.Inventory;
using Managers.GameState;
using UnityEditor;
using UnityEngine;

namespace Managers
{
    public class GameController : MonoBehaviour
    {
        public Character playerCharacter;
        public ArmourFeature armourFeature;
        public WeaponFeature weaponFeature;

        private IFeatureCommand _addArmourCommand;
        private IFeatureCommand _addWeaponCommand;
        private InventoryFacade _inventoryFacade;
        private GameContext _gameContext;

        public void Initialize() {
            _addArmourCommand = new AddFeatureCommand(playerCharacter, armourFeature);
            _addWeaponCommand = new AddFeatureCommand(playerCharacter, weaponFeature);
            _inventoryFacade = new InventoryFacade();
            _gameContext = new GameContext();
            _gameContext.SetState(new PlayingState(_gameContext));
        }

        void Update() {
            _gameContext.UpdateState();
            if (Input.GetKeyDown(KeyCode.P)) {
                _addArmourCommand.Execute();
            }
            if (Input.GetKeyDown(KeyCode.L)) {
                _addWeaponCommand.Execute();
            }
            if (Input.GetKeyDown(KeyCode.Comma)) {
                //add helmet to inventory
                Item item = new Item();
                item.Id = "Helmet";
                item.Name = "Helmet";
                item.Value = 10;
                item.Damage = 0;
                item.Weight = 5;
                _inventoryFacade.AddItemToInventory(item);
            }
        }
        
        public void SaveGame() {
            Debug.Log("Saving game...");
            GameMemento saveState = _gameContext.SaveToMemento();
            // Save the game state to a file
            
        }
        private void LoadGame() {
            Debug.Log("Loading game...");
            // Load the game state from a file
            GameMemento saveState = new GameMemento("Some saved state");
            _gameContext.RestoreFromMemento(saveState);
        }
    }
}