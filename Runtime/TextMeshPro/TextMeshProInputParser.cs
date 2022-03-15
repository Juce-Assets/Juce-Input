using Juce.CoreUnity.ControlSchemeIcons;
using Juce.Input.Devices;
using Juce.Input.InputPath;
using Juce.Input.Tags;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Juce.Input.TextMeshPro
{
    public class TextMeshProInputParser : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI text = default;
        [SerializeField] private InputActionAsset inputActionAsset = default;
        [SerializeField] private List<DeviceControlSchemeIcons> deviceControlSchemeIconsList = default;

        [Header("Debug")]
        [SerializeField] private bool verbose = default;

        private string originalText;

        private void Awake()
        {
            originalText = text.text;
        }

        private void Start()
        {
            if(InputSystemCurrentDevicesExtension.Current != null)
            {
                InputSystemCurrentDevicesExtension.Current.OnLastUsedInputDeviceChanged += OnInputDeviceChanged;
            }

            TryUpdateText();
        }

        private void OnDestroy()
        {
            if (InputSystemCurrentDevicesExtension.Current != null)
            {
                InputSystemCurrentDevicesExtension.Current.OnLastUsedInputDeviceChanged -= OnInputDeviceChanged;
            }
        }

        private void OnInputDeviceChanged(int inputDeviceId)
        {
            TryUpdateText();
        }

        private void TryUpdateText()
        {
            if(InputSystemCurrentDevicesExtension.Current == null)
            {
                return;
            }

            bool found = InputSystemCurrentDevicesExtension.Current.TryGetLastInputDevice(
                out InputDevice inputDevice
                );

            if (!found)
            {
                return;
            }

            LogVerbose($"Updating text for input device: {inputDevice.name}");

            InputSystemCurrentDevicesExtension.Current.TryGetKeyboardInputDevice(
                out InputDevice keyboardInputDevice
                );

            UpdateTextForInputDevice(inputDevice, defaultInputDevice: keyboardInputDevice);
        }

        private void UpdateTextForInputDevice(
            InputDevice inputDevice,
            InputDevice defaultInputDevice
            )
        {
            List<XmlNode> nodes = InputTagsParser.Parse(originalText);

            foreach (XmlNode node in nodes)
            {
                bool iconFound = TryGetControlSchemeIconItem(
                    inputDevice,
                    node.InnerText,
                    out IControlSchemeIconItem controlSchemeIconItem
                    );

                if(!iconFound)
                {
                    iconFound = TryGetControlSchemeIconItem(
                        defaultInputDevice,
                        node.InnerText,
                        out controlSchemeIconItem
                        );

                    if (iconFound)
                    {
                        UnityEngine.Debug.Log($"Icon not found for device {inputDevice.path}. " +
                            $"Using default {defaultInputDevice.path}", gameObject);
                    }
                    else
                    {
                        text.text = InputTagsParser.ReplaceTag(
                            originalText,
                            node.InnerText,
                            $"Not found {node.InnerText}"
                            );

                        continue;
                    }
                }

                string iconPath = TextMeshProUtils.BuildMarkdownForSprite(
                    controlSchemeIconItem.AtlasAsset,
                    controlSchemeIconItem.AtlasName
                    );

                text.text = InputTagsParser.ReplaceTag(
                    originalText,
                    node.InnerText,
                    iconPath
                    );
            }
        }

        private bool TryGetControlSchemeIconItem(
            InputDevice inputDevice, 
            string actionName,
            out IControlSchemeIconItem controlSchemeIconItem
            )
        {
            bool found = TryGetInputBindingByName(
                actionName,
                inputDevice.name,
                out InputBinding foundInputBinding
                );

            if(!found)
            {
                controlSchemeIconItem = default;
                return false;
            }

            bool iconSetFound = TryGetDeviceControlSchemeIcons(
                inputDevice,
                out DeviceControlSchemeIcons deviceControlSchemeIcons
                );

            if(!iconSetFound)
            {
                controlSchemeIconItem = default;
                return false;
            }

            return deviceControlSchemeIcons.TryGet(
                foundInputBinding.effectivePath,
                out controlSchemeIconItem
                );
        }

        private bool TryGetInputBindingByName(
            string inputBindingName, 
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
                        bool isInputAction = string.Equals(inputBinding.action, inputBindingName);

                        if (!isInputAction)
                        {
                            continue;
                        }

                        bool isDevice = InputControlPathUtils.MatchesDeviceId(inputBinding, deviceName);

                        if(!isDevice)
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

        private bool TryGetDeviceControlSchemeIcons(
            InputDevice inputDevice,
            out DeviceControlSchemeIcons foundDeviceControlSchemeIcon
            )
        {
            foreach(DeviceControlSchemeIcons deviceControlSchemeIcon in deviceControlSchemeIconsList)
            {
                foreach(string devicePathId in deviceControlSchemeIcon.DevicePathIds)
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

        private void LogVerbose(string log)
        {
            if(!verbose)
            {
                return;
            }

            UnityEngine.Debug.Log(log, gameObject);
        }
    }
}
