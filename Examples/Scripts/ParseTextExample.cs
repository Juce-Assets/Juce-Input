using Juce.Input.Tags;
using Juce.Input.TextMeshPro;
using System.Xml;
using UnityEngine;

namespace Juce.Input.Examples
{
    public class ParseTextExample : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI text = default;

        private void Start()
        {
            //XmlNodeList list = InputTagsParser.Parse(text.text);

            //foreach (XmlNode node in list)
            //{
            //    text.text = InputTagsParser.ReplaceTag(
            //        text.text,
            //        node.InnerText,
            //        "Replaced!"
            //        );

            //    UnityEngine.Debug.Log($"{node.Prefix}{node.InnerText}");
            //}
        }
    }
}
