using Juce.Input.Navigation;
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

            float selectedPositionY = Mathf.Abs(selectedRectTransform.anchoredPosition.y) + (selectedRectTransform.rect.height / 2);

            // If selection below scroll view
            if (selectedPositionY > scrollViewMaxY)
            {
                float newY = selectedPositionY - scrollRect.rect.height;
                content.anchoredPosition = new Vector2(content.anchoredPosition.x, newY + verticalSpacing);

                return;
            }

            // If selection above scroll view
            if (Mathf.Abs(selectedRectTransform.anchoredPosition.y) < scrollViewMinY)
            {
                float newY = Mathf.Abs(selectedRectTransform.anchoredPosition.y) - (selectedRectTransform.rect.height / 2);
                content.anchoredPosition = new Vector2(content.anchoredPosition.x, newY - verticalSpacing);

                return;
            }
        }
    }
}
