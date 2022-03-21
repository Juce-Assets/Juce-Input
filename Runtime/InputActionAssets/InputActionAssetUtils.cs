using Juce.Input.InputPath;
using UnityEngine.InputSystem;

namespace Juce.Input.InputActionAssets
{
    public static class InputActionAssetUtils
    {
        public static bool TryGetInputBindingByActionAndDeviceName(
           InputActionAsset inputActionAsset,
           string actionName,
           string deviceName,
           out InputBinding foundInputBinding
           )
        {
            foreach (InputActionMap inputActionMap in inputActionAsset.actionMaps)
            {
                foreach (InputAction inputAction in inputActionMap.actions)
                {
                    foreach (InputBinding inputBinding in inputAction.bindings)
                    {
                        bool isInputAction = string.Equals(inputBinding.action, actionName);

                        if (!isInputAction)
                        {
                            continue;
                        }

                        bool isDevice = InputControlPathUtils.MatchesDeviceId(inputBinding, deviceName);

                        if (!isDevice)
                        {
                            continue;
                        }

                        foundInputBinding = inputBinding;
                        return true;
                    }
                }
            }

            foundInputBinding = default;
            return false;
        }
    }
}
