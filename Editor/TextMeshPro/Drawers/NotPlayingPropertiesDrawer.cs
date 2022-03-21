using Juce.Input.TextMeshPro.Data;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Juce.Input.TextMeshPro.Drawers
{
    public static class NotPlayingPropertiesDrawer
    {
        public static void Draw(
            TextMeshProInputParser target,
            SerializedPropertiesData serializedPropertiesData
            )
        {
            if(Application.isPlaying)
            {
                return;
            }

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Debug scheme:");

            string[] options = target.DeviceControlSchemeIconsList.Select(x => x == null ? "Null" : x.name).ToArray();

            int selectedIndex = serializedPropertiesData.SelectedEditorDeviceControlSchemeIndexProperty.intValue;

            selectedIndex = ClampIndex(selectedIndex, target.DeviceControlSchemeIconsList.Count);

            selectedIndex = EditorGUILayout.Popup(selectedIndex, options);

            selectedIndex = ClampIndex(selectedIndex, target.DeviceControlSchemeIconsList.Count);

            serializedPropertiesData.SelectedEditorDeviceControlSchemeIndexProperty.intValue = selectedIndex;
        }

        private static int ClampIndex(int index, int max)
        {
            if(index < 0)
            {
                return 0;
            }

            if(index >= max)
            {
                return 0;
            }

            return index;
        }
    }
}
