using UnityEngine.InputSystem;

namespace Juce.Input.InputPath
{
    public static class InputControlPathUtils
    {
        public static bool MatchesDeviceId(InputControl inputControl, string deviceId)
        {
            return InputControlPath.MatchesPrefix(deviceId, inputControl);
        }

        public static bool MatchesDeviceId(InputBinding binding, string deviceId)
        {
            InputControlList<InputControl> controls = InputSystem.FindControls(binding.path);

            foreach(InputControl control in controls)
            {
                bool matchesDevice = MatchesDeviceId(control, deviceId);

                if(!matchesDevice)
                {
                    continue;
                }

                controls.Dispose();
                return true;
            }

            controls.Dispose();
            return false;
        }

        public static string GetChildPath(InputControl inputControl)
        {
            string[] pathElements = inputControl.path.Split('/');

            if (pathElements.Length < 3)
            {
                return string.Empty;
            }

            if(pathElements.Length == 4)
            {
                return pathElements[3];
            }

            string finalPath = string.Empty;
            for (int i = 2; i < pathElements.Length; ++i)
            {
                finalPath += pathElements[i];

                if (i + 1 < pathElements.Length)
                {
                    finalPath += '/';
                }
            }

            return finalPath;
        }
    }
}
