using System.Collections.Generic;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemes.Keyboard
{
    [CreateAssetMenu(fileName = "KeyboardControlScheme", menuName = "Juce/ControlSchemes/Keyboard", order = 1)]
    public class KeyboardControlScheme : ScriptableObject
    {
        [SerializeField, SerializeReference] public List<KeyboardControlSchemeItem> Items = new List<KeyboardControlSchemeItem>();
    }
}
