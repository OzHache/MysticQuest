using System.Collections.Generic;
using CharacterUtilities.Commands;
using UnityEngine;

namespace CharacterUtilities
{
    public class InputHandler : MonoBehaviour
    {
        public Character character;
        private Dictionary<IActionCommand.CommandType, IActionCommand> _commands;
        
        void Start() {
            _commands = new Dictionary<IActionCommand.CommandType, IActionCommand>();
            _commands.Add(IActionCommand.CommandType.Idle, new IdleActionCommand(character));
            _commands.Add(IActionCommand.CommandType.Jump, new JumpActionCommand(character));
            _commands.Add(IActionCommand.CommandType.Walk, new WalkActionCommand(character));
            //additional commands can be added here
        }

        void Update()
        {
            var inputValues = GetInputValues();

            ExecuteCommands(inputValues);
        }

        private void ExecuteCommands(InputValues inputValues)
        {
            //Execute Commands based on Input Values
            if (inputValues.Jump) {
                _commands[IActionCommand.CommandType.Jump].Execute(inputValues); // Jump
                Debug.Log("Jump State");
            } else if (inputValues.Horizontal != 0 || inputValues.Vertical != 0) {
                _commands[IActionCommand.CommandType.Walk].Execute(inputValues); // Walk
                Debug.Log("Walk State");
            } else {
                _commands[IActionCommand.CommandType.Idle].Execute(inputValues); // Idle
                Debug.Log("Idle State");
            }
        }

        private InputValues GetInputValues()
        {
            //Fill Input Values
            var inputValues = new InputValues();
            inputValues.Horizontal = Input.GetAxisRaw("Horizontal");
            inputValues.Vertical = Input.GetAxisRaw("Vertical");
            inputValues.Jump = Input.GetButtonDown("Jump");
            //additional input values can be added here
            
            return inputValues;
        }
    }
}