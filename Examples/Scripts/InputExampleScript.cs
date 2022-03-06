using Juce.CoreUnity.ControlSchemeIcons;
using Juce.Input.Devices;
using Juce.Input.Extensions;
using Juce.Input.InputActions;
using Juce.Input.InputPath;
using Juce.Input.TextMeshPro;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

using static UnityEngine.InputSystem.InputAction;

namespace Juce.Input.Examples
{
    public class InputExampleScript : MonoBehaviour
    {
        [SerializeField] private DeviceControlSchemeIcons deviceControlSchemeIcons = default;
        [SerializeField] private TMPro.TextMeshProUGUI text = default;

        private ExampleInputActions exampleInputActions;

        private string lastPath = string.Empty;

        void Start()
        {
            exampleInputActions = new ExampleInputActions();

            exampleInputActions.Enable();

            exampleInputActions.ActionA.A.performed += OnAction;
            exampleInputActions.ActionDPad.DPadLeft.performed += OnAction;
        }

        private void Update()
        {
            InputControl gamepadButtonPressed = Gamepad.current.allControls.Where(x => x is ButtonControl button && x.IsPressed() && !x.synthetic).FirstOrDefault();

            if (gamepadButtonPressed != null)
            {
                if(string.Equals(lastPath, gamepadButtonPressed.path))
                {
                    return;
                }

                lastPath = gamepadButtonPressed.path;

                UnityEngine.Debug.Log(gamepadButtonPressed.path);
            }
        }

        private void OnAction(CallbackContext callbackContext)
        {
            InputDeviceType inputDeviceType = callbackContext.action.activeControl.device.ToInputDeviceType();

            switch (inputDeviceType)
            {
                default:
                case InputDeviceType.Keyboard:
                    {
                        Keyboard keyboard = callbackContext.action.activeControl.device as Keyboard;
                        //configuration.DefaultKeyboardControlSchemeIcons.TryGet(inputAction.)
                    }
                    break;

                case InputDeviceType.Gamepad:
                    {

                    }
                    break;
            }

            InputActionsUtils.TryGetInputActionByName(
                exampleInputActions,
                "A",
                out InputAction inputAction
                );

            foreach (InputBinding binding in inputAction.bindings)
            {
                bool matchesControl = InputControlPathUtils.MatchesDeviceId(binding, deviceControlSchemeIcons.DevicePathId);
            }

            bool matches = InputControlPathUtils.MatchesDeviceId(callbackContext.action.activeControl, deviceControlSchemeIcons.DevicePathId);

            string childPath = InputControlPathUtils.GetChildPath(callbackContext.action.activeControl);

            if (matches)
            {
                bool found = deviceControlSchemeIcons.TryGet(
                    childPath,
                    out IControlSchemeIconItem controlSchemeIconItem
                    );

                if(found)
                {
                    UnityEngine.Debug.Log($"Found {controlSchemeIconItem.InputPath} {controlSchemeIconItem.AtlasAsset} {controlSchemeIconItem.AtlasName}");

                    text.text = TextMeshProUtils.BuildMarkdownForSprite(
                        controlSchemeIconItem.AtlasAsset, 
                        controlSchemeIconItem.AtlasName
                        );
                }
            }

            UnityEngine.Debug.Log(callbackContext.action.activeControl.path);
            UnityEngine.Debug.Log(InputControlPath.MatchesPrefix(deviceControlSchemeIcons.DevicePathId, callbackContext.action.activeControl));
        }
    }
}
