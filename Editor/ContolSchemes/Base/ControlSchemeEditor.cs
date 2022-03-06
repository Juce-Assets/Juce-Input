using Juce.CoreUnity.ControlSchemes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Juce.CoreUnity.ControlSchemes.Base
{
    public static class ControlSchemeEditor 
    {
        public static T[] GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToArray();
        }

        public static bool HasItem<TKey>(IReadOnlyList<ControlSchemeItem<TKey>> allItems, TKey itemKey) where TKey : Enum
        {
            foreach (ControlSchemeItem<TKey> item in allItems)
            {
                bool areSameKey = Comparer<TKey>.Default.Compare(item.Key, itemKey) >= 0;

                if (areSameKey)
                {
                    return true;
                }
            }

            return false;
        }

        public static void DrawItems<TKey>(IReadOnlyList<ControlSchemeItem<TKey>> allItems) where TKey : Enum
        {
            foreach (ControlSchemeItem<TKey> item in allItems)
            {
                using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
                {
                    EditorGUILayout.LabelField(item.Key.ToString());
                    item.Sprite = (Sprite)EditorGUILayout.ObjectField(item.Sprite, typeof(Sprite), allowSceneObjects: false);
                }
            }
        }
    }
}
