using System.Collections.Generic;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemeIcons
{
    [CreateAssetMenu(fileName = "DeviceControlSchemeIcons", menuName = "Juce/Input/DeviceControlSchemeIcons", order = 1)]
    public class DeviceControlSchemeIcons : ScriptableObject
    {
        [SerializeField] private List<string> devicePathIds = default;
        [SerializeField] private List<ControlSchemeIconItem> items = new List<ControlSchemeIconItem>();

        public IReadOnlyList<string> DevicePathIds => devicePathIds;
        public IReadOnlyList<ControlSchemeIconItem> Items => items;
    }
}
