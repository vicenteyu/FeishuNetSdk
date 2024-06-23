namespace FeishuNetSdk
{
    internal static class HttpContentExtension
    {
        public static bool IsJsonContent(this System.Net.Http.Headers.HttpContentHeaders headers)
        {
            return headers.Any(p => p.Key == "Content-Type" && p.Value.Any(k => k.Contains("application/json")));
        }
    }
}
