using UnityEngine;
using CharacterUtilities;
using CharacterUtilities.Features;


namespace Managers
{
    public class GameInitializer : MonoBehaviour
    {
        [SerializeField] private CharacterData characterData;
        private Character _character;
        
        void Awake() {
            CharacterBuilder builder = new CharacterBuilder();
            Character warrior = builder.WithArmor("Heavy").WithWeapon("Sword").WithPower(10).Build(characterData);
            Character warriorClone = (Character)warrior.Clone(); // Cloning the warrior

            // Customize the clone if needed
            warriorClone.weapon = "Axe";
        
            // Position the characters in the scene
            warrior.transform.position = new Vector3(0, 0, 0);
            warriorClone.transform.position = new Vector3(2, 0, 0);
            
            //set up the Game Controller
            GameObject manager = new GameObject("Manager");
            GameController gameController = manager.AddComponent<GameController>();
            gameController.playerCharacter = warrior;
            gameController.armourFeature = warrior.gameObject.AddComponent<ArmourFeature>();
            gameController.weaponFeature = warrior.gameObject.AddComponent<WeaponFeature>();
            gameController.Initialize();
            
            //Set up Input
            GameObject inputHandler = new GameObject("InputHandler");
            InputHandler inputHandlerComponent = inputHandler.AddComponent<InputHandler>();
            inputHandlerComponent.character = warrior;
            
            //Set up Camera
            GameObject camera = new GameObject("Camera");
            CameraFollow2D cameraFollow2D = camera.AddComponent<CameraFollow2D>();
            cameraFollow2D.Initialize(warrior.gameObject);
            
        }
    }

}