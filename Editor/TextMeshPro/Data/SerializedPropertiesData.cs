using UnityEditor;

namespace Juce.Input.TextMeshPro.Data
{
    public class SerializedPropertiesData
    {
        public SerializedProperty TextProperty { get; set; }
        public SerializedProperty InputActionAssetProperty { get; set; }
        public SerializedProperty DeviceControlSchemeIconsListProperty { get; set; }

        public SerializedProperty OriginalTextProperty { get; set; }

        public SerializedProperty SelectedEditorDeviceControlSchemeIndexProperty { get; set; }
        public SerializedProperty VerboseProperty { get; set; }
    }
}
