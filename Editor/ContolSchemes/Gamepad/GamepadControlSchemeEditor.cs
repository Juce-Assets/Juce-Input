using Juce.CoreUnity.ControlSchemes.Base;
using UnityEditor;
using UnityEngine.InputSystem.LowLevel;

namespace Juce.CoreUnity.ControlSchemes.Gamepad
{
    [CustomEditor(typeof(GamepadControlScheme))]
    public class GamepadControlSchemeEditor : Editor
    {
        private GamepadControlScheme actualTarget;
        protected GamepadButton[] Keys { get; private set; }

        private void OnEnable()
        {
            actualTarget = (GamepadControlScheme)target;

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
            Keys = ControlSchemeEditor.GetValues<GamepadButton>();
        }

        private void FillItemsList()
        {
            foreach (GamepadButton key in Keys)
            {
                bool hasItem = ControlSchemeEditor.HasItem(actualTarget.Items, key);

                if (hasItem)
                {
                    continue;
                }

                GamepadControlSchemeItem newItem = new GamepadControlSchemeItem()
                {
                    Key = key,
                };

                actualTarget.Items.Add(newItem);
            }
        }
    }
}
