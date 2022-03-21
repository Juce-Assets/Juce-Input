using Juce.Input.InputPath;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Juce.CoreUnity.ControlSchemeIcons
{
    public static class ControlShemeIconsUtils
    {
        public static bool TryGetIconIconByInputPath(
            DeviceControlSchemeIcons deviceControlSchemeIcons,
            string inputPath, 
            out IControlSchemeIconItem controlSchemeIconItem
            )
        {
            foreach (ControlSchemeIconItem item in deviceControlSchemeIcons.Items)
            {
                if (string.Equals(item.InputPath, inputPath))
                {
                    controlSchemeIconItem = item;
                    return true;
                }
            }

            controlSchemeIconItem = default;
            return false;
        }

        public static bool TryGetSchemeByInputDevice(
           IReadOnlyList<DeviceControlSchemeIcons> deviceControlSchemeIconsList,
           InputDevice inputDevice,
           out DeviceControlSchemeIcons foundDeviceControlSchemeIcon
           )
        {
            foreach (DeviceControlSchemeIcons deviceControlSchemeIcon in deviceControlSchemeIconsList)
            {
                foreach (string devicePathId in deviceControlSchemeIcon.DevicePathIds)
                {
                    bool isDevice = InputControlPathUtils.MatchesDeviceId(inputDevice, devicePathId);

                    if (!isDevice)
                    {
                        continue;
                    }

                    foundDeviceControlSchemeIcon = deviceControlSchemeIcon;
                    return true;
                }
            }

            foundDeviceControlSchemeIcon = default;
            return false;
        }
    }
}
