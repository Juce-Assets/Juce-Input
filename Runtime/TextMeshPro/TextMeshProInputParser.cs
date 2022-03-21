using Juce.CoreUnity.ControlSchemeIcons;
using Juce.Input.Devices;
using Juce.Input.InputActionAssets;
using Juce.Input.InputParsing;
using Juce.Input.Tags;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Juce.Input.TextMeshPro
{
    [ExecuteInEditMode]
    public class TextMeshProInputParser : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TMPro.TextMeshProUGUI text = default;
        [SerializeField] private InputActionAsset inputActionAsset = default;
        [SerializeField] private List<DeviceControlSchemeIcons> deviceControlSchemeIconsList = default;

        [SerializeField, TextArea] private string originalText = default;

        [Header("Debug")]
        [SerializeField, Min(0)] private int selectedEditorDeviceControlSchemeIndex = default;

        public IReadOnlyList<DeviceControlSchemeIcons> DeviceControlSchemeIconsList => deviceControlSchemeIconsList;
        public string Text { get => originalText; set => originalText = value; }

        private void Start()
        {
            if (Application.isPlaying)
            {
                if (InputSystemCurrentDevicesExtension.Current != null)
                {
                    InputSystemCurrentDevicesExtension.Current.OnLastUsedInputDeviceChanged += OnInputDeviceChanged;
                }

                TryUpdateText();
            }
        }

        private void Update()
        {
            if (!Application.isPlaying)
            {
                TryUpdateTextEditor();
            }
        }

        private void OnDestroy()
        {
            if (Application.isPlaying)
            {
                if (InputSystemCurrentDevicesExtension.Current != null)
                {
                    InputSystemCurrentDevicesExtension.Current.OnLastUsedInputDeviceChanged -= OnInputDeviceChanged;
                }
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

            InputSystemCurrentDevicesExtension.TryGetKeyboardInputDevice(
                out InputDevice keyboardInputDevice
                );

            UpdateText(inputDevice, defaultInputDevice: keyboardInputDevice);
        }

        private void TryUpdateTextEditor()
        {
            if(deviceControlSchemeIconsList.Count == 0)
            {
                return;
            }

            if(deviceControlSchemeIconsList.Count <= selectedEditorDeviceControlSchemeIndex)
            {
                return;
            }

            DeviceControlSchemeIcons deviceControlSchemeIcons = deviceControlSchemeIconsList[selectedEditorDeviceControlSchemeIndex];

            if(deviceControlSchemeIcons == null)
            {
                return;
            }

            UpdateText(deviceControlSchemeIcons);
        }

        private void UpdateText(
            InputDevice inputDevice,
            InputDevice defaultInputDevice
            )
        {
            List<XmlNode> nodes = InputTagsParser.Parse(originalText);

            string currentText = originalText;

            foreach (XmlNode node in nodes)
            {
                bool iconFound = InputParsingUtils.TryGetControlSchemeIcon(
                    inputActionAsset,
                    deviceControlSchemeIconsList,
                    inputDevice,
                    node.InnerText,
                    out IControlSchemeIconItem controlSchemeIconItem
                    );

                if(!iconFound)
                {
                    iconFound = InputParsingUtils.TryGetControlSchemeIcon(
                        inputActionAsset,
                        deviceControlSchemeIconsList,
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
                            currentText,
                            node.InnerText,
                            $"Not found {node.InnerText}"
                            );

                        continue;
                    }
                }

                currentText = UpdateTextForControlScheme(
                    node.InnerText,
                    controlSchemeIconItem,
                    currentText
                    );
            }

            text.text = currentText;
        }

        private void UpdateText(
            DeviceControlSchemeIcons deviceControlSchemeIcons
            )
        {
            if (deviceControlSchemeIcons.DevicePathIds.Count == 0)
            {
                return;
            }

            string deviceId = deviceControlSchemeIcons.DevicePathIds[0];

            List<XmlNode> nodes = InputTagsParser.Parse(originalText);

            string currentText = originalText;

            foreach (XmlNode node in nodes)
            {
                bool found = InputActionAssetUtils.TryGetInputBindingByActionAndDeviceName(
                    inputActionAsset,
                    node.InnerText,
                    deviceId,
                    out InputBinding foundInputBinding
                    );

                if(!found)
                {
                    continue;
                }

                bool iconFound = ControlShemeIconsUtils.TryGetIconIconByInputPath(
                    deviceControlSchemeIcons,
                    foundInputBinding.effectivePath,
                    out IControlSchemeIconItem controlSchemeIconItem
                    );

                if(!iconFound)
                {
                    continue;
                }

                currentText = UpdateTextForControlScheme(
                    node.InnerText,
                    controlSchemeIconItem,
                    currentText
                    );
            }

            text.text = currentText;
        }

        private string UpdateTextForControlScheme(
            string actionName,
            IControlSchemeIconItem controlSchemeIconItem,
            string currentText
            )
        {
            string iconPath = TextMeshProUtils.BuildMarkdownForSprite(
                controlSchemeIconItem.AtlasAsset,
                controlSchemeIconItem.AtlasName
                );

            return InputTagsParser.ReplaceTag(
                currentText,
                actionName,
                iconPath
                );
        }
    }
}
