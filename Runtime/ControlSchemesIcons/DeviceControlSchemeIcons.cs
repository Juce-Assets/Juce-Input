﻿using System.Collections.Generic;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemeIcons
{
    [CreateAssetMenu(fileName = "DeviceControlSchemeIcons", menuName = "Juce/Input/DeviceControlSchemeIcons", order = 1)]
    public class DeviceControlSchemeIcons : ScriptableObject
    {
        [SerializeField] private string devicePathId = default;
        [SerializeField] private List<ControlSchemeIconItem> items = new List<ControlSchemeIconItem>();

        public string DevicePathId => devicePathId;

        public bool TryGet(string inputPath, out IControlSchemeIconItem controlSchemeIconItem)
        {
            foreach (ControlSchemeIconItem item in items)
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
    }
}
