using System.Collections.Generic;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemes.Gamepad
{
    [CreateAssetMenu(fileName = "GamepadControlSchemes", menuName = "Juce/ControlSchemes/Gamepad", order = 1)]
    public class GamepadControlScheme : ScriptableObject
    {
        [SerializeField, SerializeReference] public List<GamepadControlSchemeItem> Items = new List<GamepadControlSchemeItem>();
    }
}
