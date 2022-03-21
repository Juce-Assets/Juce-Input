using UnityEngine;

namespace Juce.CoreUnity.ControlSchemeIcons
{
    [System.Serializable]
    public class ControlSchemeIconItem : IControlSchemeIconItem
    {
        [Header("Key")]
        [SerializeField] private string inputPath = default;

        [Header("Atlas")]
        [SerializeField] private string atlasAsset = default;
        [SerializeField] private string atlasName = default;

        public string InputPath => inputPath;
        public string AtlasAsset => atlasAsset;
        public string AtlasName => atlasName;
    }
}
