using Juce.Input.Devices;
using Juce.Input.Extensions;
using UnityEngine.InputSystem;

namespace Juce.CoreUnity.ControlSchemeIcons.Utils
{
    public static class TextMeshProUtilss
    {
        public static string GetIconForInputAction(
            ControlSchemesIconsConfiguration configuration,
            InputAction inputAction
            )
        {
            InputDeviceType inputDeviceType = inputAction.activeControl.device.ToInputDeviceType();

            switch (inputDeviceType)
            {
                default:
                case InputDeviceType.Keyboard:
                    {
                        Keyboard keyboard = inputAction.activeControl.device as Keyboard;
                        //configuration.DefaultKeyboardControlSchemeIcons.TryGet(inputAction.)
                    }
                    break;

                case InputDeviceType.Gamepad:
                    {
      
                    }
                   break;
            }

            UnityEngine.Debug.Log(inputAction.activeControl.path);
            UnityEngine.Debug.Log(InputControlPath.MatchesPrefix("<Keyboard>", inputAction.activeControl));

            return string.Empty;
        }
    }
}
