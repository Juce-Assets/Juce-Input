using Juce.Input.Devices;
using UnityEngine.InputSystem;

namespace Juce.Input.Extensions
{
    public static class InputDeviceExtensions
    {
        public static InputDeviceType ToInputDeviceType(this InputDevice inputDevice)
        {
            switch(inputDevice)
            {
                case Gamepad _:
                    {
                        return InputDeviceType.Gamepad;
                    }

                case Keyboard _:
                    {
                        return InputDeviceType.Keyboard;
                    }
            }

            return InputDeviceType.Other;
        }
    }
}
