using Juce.Input.TextMeshPro.Data;

namespace Juce.Input.TextMeshPro.Logic
{
    public static class GatherSerializedPropertiesLogic
    {
        public static void Execute(
            TextMeshProInputParserEditor editor,
            SerializedPropertiesData serializedPropertiesData
            )
        {
            serializedPropertiesData.TextProperty = editor.serializedObject.FindProperty("text");
            serializedPropertiesData.InputActionAssetProperty = editor.serializedObject.FindProperty("inputActionAsset");
            serializedPropertiesData.DeviceControlSchemeIconsListProperty = editor.serializedObject.FindProperty("deviceControlSchemeIconsList");

            serializedPropertiesData.OriginalTextProperty = editor.serializedObject.FindProperty("originalText");

            serializedPropertiesData.SelectedEditorDeviceControlSchemeIndexProperty = editor.serializedObject.FindProperty("selectedEditorDeviceControlSchemeIndex");
            serializedPropertiesData.VerboseProperty = editor.serializedObject.FindProperty("verbose");
        }
    }
}
