using UnityEngine;
using UnityEngine.UI;

namespace Juce.Input.ScrollView
{
    public class ScrollbarStepsByScrollviewSize : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Scrollbar scrollbar = default;
        [SerializeField] private RectTransform scrollRectContent = default;

        [Header("Values")]
        [SerializeField, Min(0)] private float stepDistance = default;

        private void Update()
        {
            TrySetStepDistance();
        }

        private void TrySetStepDistance()
        {
            float stepsCount = 0;

            if(stepDistance > 0)
            {
                stepsCount = scrollRectContent.sizeDelta.y / stepDistance;
            }

            scrollbar.numberOfSteps = (int)stepsCount;
        }
    }
}
