using Juce.CoreUnity.ControlSchemes.Base;
using UnityEditor;
using UnityEngine.InputSystem;

namespace Juce.CoreUnity.ControlSchemes.Keyboard
{
    [CustomEditor(typeof(KeyboardControlScheme))]
    public class KeyboardControlSchemeEditor : Editor
    {
        private KeyboardControlScheme actualTarget;
        protected Key[] Keys { get; private set; }

        private void OnEnable()
        {
            actualTarget = (KeyboardControlScheme)target;

            GatherKeys();

            FillItemsList();
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            ControlSchemeEditor.DrawItems(actualTarget.Items);

            serializedObject.ApplyModifiedProperties();
        }

        private void GatherKeys()
        {
            Keys = ControlSchemeEditor.GetValues<Key>();
        }

        private void FillItemsList()
        {
            foreach (Key key in Keys)
            {
                bool hasItem = ControlSchemeEditor.HasItem(actualTarget.Items, key);

                if (hasItem)
                {
                    continue;
                }

                KeyboardControlSchemeItem newItem = new KeyboardControlSchemeItem()
                {
                    Key = key,
                };

                actualTarget.Items.Add(newItem);
            }
        }
    }
}
