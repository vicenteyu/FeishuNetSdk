// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="TemplateCardDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>卡片模板</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片模板
    /// </summary>
    public record TemplateCardDto : MessageCard
    {
        /// <summary>
        /// 如果使用卡片模板，请填写此项，固定值为：template
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; } = "template";

        /// <summary>
        /// 卡片模板内容
        /// </summary>
        [JsonPropertyName("data")]
        public TemplateCardData Data { get; set; } = new();

        /// <summary>
        /// 卡片模板内容
        /// </summary>
        public record TemplateCardData
        {
            /// <summary>
            /// 模板ID
            /// </summary>
            [JsonPropertyName("template_id")]
            public string TemplateId { get; set; } = string.Empty;

            /// <summary>
            /// 卡片模版的版本。在卡片搭建工具中获取。详情参考预览与发布卡片中的管理卡片版本一节。
            /// </summary>
            [JsonPropertyName("template_version_name")]
            public string? TemplateVersionName { get; set; }

            /// <summary>
            /// 模板变量集合，Key-Value
            /// </summary>
            [JsonPropertyName("template_variable")]
            public Dictionary<string, string> TemplateVariable { get; set; } = [];
        }

        /// <summary>
        /// 输出格式化字符串
        /// </summary>
        public override string ToString() => System.Text.Json.JsonSerializer.Serialize(this);
    }
}
