using UnityEngine.InputSystem;

namespace Juce.Input.InputActions
{
    public static class InputActionsUtils
    {
        public static bool TryGetInputActionByName(
            IInputActionCollection inputActionCollection, 
            string inputActionName,
            out InputAction foundInputAction
            )
        {
            foreach(InputAction inputAction in inputActionCollection)
            {
                if(string.Equals(inputActionName, inputAction.name))
                {
                    foundInputAction = inputAction;
                    return true;
                }
            }

            foundInputAction = default;
            return false;
        }
    }
}
