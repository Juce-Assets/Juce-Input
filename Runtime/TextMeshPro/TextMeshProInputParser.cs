#if JUCE_TEXT_MESH_PRO_EXTENSIONS

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

            UpdateTextForInputDevice(inputDevice);
        }

        private void UpdateTextForInputDevice(InputDevice inputDevice)
        {
            List<XmlNode> nodes = InputTagsParser.Parse(originalText);

            foreach (XmlNode node in nodes)
            {
                bool found = TryGetInputBindingByName(
                    node.InnerText,
                    inputDevice.name,
                    out InputBinding foundInputBinding
                    );

                if (!found)
                {
                    LogVerbose($"Binding with name {node.InnerText} could not be found");

                    text.text = InputTagsParser.ReplaceTag(
                        originalText,
                        node.InnerText,
                        node.InnerText
                        );

                    continue;
                }

                bool iconSetFound = TryGetDeviceControlSchemeIcons(
                    inputDevice,
                    out DeviceControlSchemeIcons deviceControlSchemeIcons
                    );

                if(!iconSetFound)
                {
                    LogVerbose($"DeviceControlScheme with name {inputDevice.name} could not be found");

                    text.text = InputTagsParser.ReplaceTag(
                        originalText,
                        node.InnerText,
                        foundInputBinding.effectivePath
                        );

                    continue;
                }

                bool foundIcons = deviceControlSchemeIcons.TryGet(
                    foundInputBinding.effectivePath,
                    out IControlSchemeIconItem controlSchemeIconItem
                    );

                if (!foundIcons)
                {
                    LogVerbose($"Icon with path {foundInputBinding.effectivePath} could not be found");

                    text.text = InputTagsParser.ReplaceTag(
                        originalText,
                        node.InnerText,
                        foundInputBinding.effectivePath
                        );

                    continue;
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

#endif 
