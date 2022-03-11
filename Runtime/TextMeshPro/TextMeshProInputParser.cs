#if JUCE_TEXT_MESH_PRO_EXTENSIONS

using Juce.CoreUnity.ControlSchemeIcons;
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
        [SerializeField] private DeviceControlSchemeIcons deviceControlSchemeIcons = default;

        private void Awake()
        {
            UpdateText();
        }

        private void UpdateText()
        {
            List<XmlNode> nodes = InputTagsParser.Parse(text.text);

            foreach (XmlNode node in nodes)
            {
                foreach (InputActionMap inputActionMap in inputActionAsset.actionMaps)
                {
                    foreach (InputAction inputAction in inputActionMap.actions)
                    {
                        foreach (InputBinding inputBinding in inputAction.bindings)
                        {
                            bool isInputAction = string.Equals(inputBinding.action, node.InnerText);

                            if (!isInputAction)
                            {
                                continue;
                            }

                            bool found = deviceControlSchemeIcons.TryGet(
                                inputBinding.effectivePath,
                                out IControlSchemeIconItem controlSchemeIconItem
                                );

                            if(!found)
                            {
                                continue;
                            }

                            string iconPath = TextMeshProUtils.BuildMarkdownForSprite(
                                controlSchemeIconItem.AtlasAsset,
                                controlSchemeIconItem.AtlasName
                                );

                            text.text = InputTagsParser.ReplaceTag(
                                text.text,
                                node.InnerText,
                                iconPath
                                );
                        }
                    }
                }
            }
        }
    }
}

#endif 
