using Juce.Input.InputActions;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Juce.Input.Devices
{
    public class InputSystemCurrentDevicesExtension : MonoBehaviour
    {
        private readonly AnyKeyInputAction anyKeyInputAction = new AnyKeyInputAction();

        public int LastUsedInputDeviceId { get; private set; }

        public event Action<int> OnLastUsedInputDeviceChanged;

        public static InputSystemCurrentDevicesExtension Current = null;

        private void Awake()
        {
            TryFindLastUsedDevice();

            InputSystem.onDeviceChange += OnDeviceChange;

            anyKeyInputAction.InputAction.Enable();
            anyKeyInputAction.InputAction.performed += OnAnyKeyPressed;

            Current = this;
        }

        private void OnDestroy()
        {
            InputSystem.onDeviceChange -= OnDeviceChange;

            anyKeyInputAction.InputAction.performed -= OnAnyKeyPressed;
            anyKeyInputAction.InputAction.Disable();
        }

        private void TryFindLastUsedDevice()
        {
            if(Gamepad.current != null)
            {
                TrySetNewInputDevice(Gamepad.current);
                return;
            }

            if(Keyboard.current != null)
            {
                TrySetNewInputDevice(Keyboard.current);
                return;
            }

            if(InputSystem.devices.Count > 0)
            {
                TrySetNewInputDevice(InputSystem.devices[0]);
                return;
            }

            UnityEngine.Debug.Log("No input device found at startup", gameObject);
            LastUsedInputDeviceId = InputDevice.InvalidDeviceId;
        }

        private void TrySetNewInputDevice(InputDevice inputDevice)
        {
            int newInputDeviceId = inputDevice.deviceId;

            if (newInputDeviceId == LastUsedInputDeviceId)
            {
                return;
            }

            LastUsedInputDeviceId = newInputDeviceId;
            OnLastUsedInputDeviceChanged?.Invoke(LastUsedInputDeviceId);
        }

        private void OnDeviceChange(InputDevice inputDevice, InputDeviceChange inputDeviceChange)
        {
            switch(inputDeviceChange)
            {
                case InputDeviceChange.Added:
                    {
                        TrySetNewInputDevice(inputDevice);
                    }
                    break;

                case InputDeviceChange.Disconnected:
                    {
                        TryFindLastUsedDevice();
                    }
                    break;
            }
        }

        private void OnAnyKeyPressed(CallbackContext callbackContext)
        {
            TrySetNewInputDevice(callbackContext.action.activeControl.device);
        }

        public bool TryGetLastInputDevice(out InputDevice inputDevice)
        {
            if(LastUsedInputDeviceId == InputDevice.InvalidDeviceId)
            {
                inputDevice = default;
                return false;
            }

            inputDevice = InputSystem.GetDeviceById(LastUsedInputDeviceId);
            return inputDevice != null;
        }
    }
}
