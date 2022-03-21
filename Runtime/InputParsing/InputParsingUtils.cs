using Juce.CoreUnity.ControlSchemeIcons;
using Juce.Input.InputActionAssets;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Juce.Input.InputParsing
{
    public static class InputParsingUtils
    {
        public static bool TryGetControlSchemeIcon(
           InputActionAsset inputActionAsset,
           IReadOnlyList<DeviceControlSchemeIcons> deviceControlSchemeIconsList,
           InputDevice inputDevice,
           string actionName,
           out IControlSchemeIconItem controlSchemeIconItem
           )
        {
            bool found = InputActionAssetUtils.TryGetInputBindingByActionAndDeviceName(
                inputActionAsset,
                actionName,
                inputDevice.name,
                out InputBinding foundInputBinding
                );

            if (!found)
            {
                controlSchemeIconItem = default;
                return false;
            }

            bool iconSetFound = ControlShemeIconsUtils.TryGetSchemeByInputDevice(
                deviceControlSchemeIconsList,
                inputDevice,
                out DeviceControlSchemeIcons deviceControlSchemeIcons
                );

            if (!iconSetFound)
            {
                controlSchemeIconItem = default;
                return false;
            }

            return ControlShemeIconsUtils.TryGetIconIconByInputPath(
                deviceControlSchemeIcons,
                foundInputBinding.effectivePath,
                out controlSchemeIconItem
                );
        }
    }
}
