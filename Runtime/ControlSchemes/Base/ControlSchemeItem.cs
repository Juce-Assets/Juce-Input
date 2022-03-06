using System;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemes.Base
{
    [System.Serializable]
    public abstract class ControlSchemeItem<TKey> where TKey : Enum
    {
        [SerializeField] public TKey Key = default;
        [SerializeField] public Sprite Sprite = default;

    }
}
