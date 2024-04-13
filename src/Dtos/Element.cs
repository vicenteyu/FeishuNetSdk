namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 元素
    /// </summary>
    public record Element
    {
        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; } = string.Empty;
    }
}
