using UnityEngine.InputSystem;

namespace Juce.Input.InputActions
{
    public class AnyKeyInputAction
    {
        public InputAction InputAction { get; } 

        public AnyKeyInputAction()
        {
            InputAction = new InputAction(binding: "/*/<button>", type: InputActionType.Button);
            InputAction.AddBinding("/<Gamepad>/*/*");
        }
    }
}
