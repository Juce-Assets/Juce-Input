using Juce.Input.TextMeshPro.Data;
using Juce.Input.TextMeshPro.Drawers;
using Juce.Input.TextMeshPro.Logic;
using UnityEditor;

namespace Juce.Input.TextMeshPro
{
    [CustomEditor(typeof(TextMeshProInputParser))]
    public class TextMeshProInputParserEditor : Editor
    {
        private TextMeshProInputParser actualTarget;

        private SerializedPropertiesData serializedPropertiesData { get; } = new SerializedPropertiesData();

        private void OnEnable()
        {
            actualTarget = (TextMeshProInputParser)target;

            GatherSerializedPropertiesLogic.Execute(this, serializedPropertiesData);
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            AlwaysPropertiesDrawer.Draw(serializedPropertiesData);
            NotPlayingPropertiesDrawer.Draw(actualTarget, serializedPropertiesData);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
