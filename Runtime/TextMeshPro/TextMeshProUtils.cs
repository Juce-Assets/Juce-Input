namespace Juce.Input.TextMeshPro
{
    public static class TextMeshProUtils
    {
        public static string BuildMarkdownForSprite(string atlasAsset, string atlasName)
        {
            return string.Format(
                "<sprite=\"{0}\" name=\"{1}\">",
                atlasAsset,
                atlasName
                );
        }
    }
}
