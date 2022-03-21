using Juce.Input.TextMeshPro.Data;
using UnityEditor;

namespace Juce.Input.TextMeshPro.Drawers
{
    public static class AlwaysPropertiesDrawer
    {
        public static void Draw(SerializedPropertiesData serializedPropertiesData)
        {
            EditorGUILayout.PropertyField(serializedPropertiesData.TextProperty);
            EditorGUILayout.PropertyField(serializedPropertiesData.InputActionAssetProperty);
            EditorGUILayout.PropertyField(serializedPropertiesData.DeviceControlSchemeIconsListProperty);

            EditorGUILayout.PropertyField(serializedPropertiesData.OriginalTextProperty);
        }
    }
}
