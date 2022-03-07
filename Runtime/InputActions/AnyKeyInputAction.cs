using System;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Juce.Input.InputActions
{
    public class AnyKeyInputAction
    {
        private readonly InputAction inputAction;

        public event Action<CallbackContext> Performed;

        public AnyKeyInputAction()
        {
            inputAction = new InputAction(binding: "/*/<button>", type: InputActionType.Button);
            inputAction.AddBinding("/<Gamepad>/*/*");

            inputAction.performed += Performed;
        }
    }
}
