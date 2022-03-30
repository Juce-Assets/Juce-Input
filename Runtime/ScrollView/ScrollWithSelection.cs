using Juce.Input.Navigation;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Juce.Input.ScrollView
{
    public class ScrollWithSelection : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private RectTransform scrollRect = default;
        [SerializeField] private RectTransform scrollRectContent = default;

        [Header("Values")]
        [SerializeField, Min(0)] private float verticalSpacing = default;

        private GameObject previouslySelected;

        private void Update()
        {
            TryScroll(scrollRect, scrollRectContent);
        }

        private void TryScroll(RectTransform scrollRect, RectTransform content)
        {
            if(InputSystemUIInputModuleNavigationExtension.Current != null)
            {
                if(!InputSystemUIInputModuleNavigationExtension.Current.IsUsingSelectables)
                {
                    return;
                }
            }

            GameObject selected = EventSystem.current.currentSelectedGameObject;

            bool noNeedToUpdate = selected == null || selected == previouslySelected;

            if(noNeedToUpdate)
            {
                return;
            }

            bool selectedIsNotContent = selected.transform.parent != content.transform;

            if(selectedIsNotContent)
            {
                return;
            }

            RectTransform selectedRectTransform = selected.GetComponent<RectTransform>();

            float scrollViewMinY = content.anchoredPosition.y;
            float scrollViewMaxY = content.anchoredPosition.y + scrollRect.rect.height;

            float selectedPositionMinY = Mathf.Abs(selectedRectTransform.anchoredPosition.y) - (selectedRectTransform.rect.height / 2);
            float selectedPositionMaxY = Mathf.Abs(selectedRectTransform.anchoredPosition.y) + (selectedRectTransform.rect.height / 2);

            // If selection below scroll view
            if (selectedPositionMaxY > scrollViewMaxY)
            {
                float newY = selectedPositionMaxY - scrollRect.rect.height;
                float newYWithVerticalSpacing = newY + verticalSpacing;

                content.anchoredPosition = new Vector2(content.anchoredPosition.x, newYWithVerticalSpacing);

                return;
            }

            // If selection above scroll view
            if (selectedPositionMinY < scrollViewMinY)
            {
                float newYWithVerticalSpacing = selectedPositionMinY - verticalSpacing;
                newYWithVerticalSpacing = Math.Max(0, newYWithVerticalSpacing);

                content.anchoredPosition = new Vector2(content.anchoredPosition.x, newYWithVerticalSpacing);

                return;
            }
        }
    }
}
