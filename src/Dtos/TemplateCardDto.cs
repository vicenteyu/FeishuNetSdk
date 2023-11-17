using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 卡片模板
    /// </summary>
    public record TemplateCardDto
    {
        /// <summary>
        /// 如果使用卡片模板，请填写此项，固定值为：template
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "template";

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
            /// 模板变量集合，Key-Value
            /// </summary>
            [JsonPropertyName("template_variable")]
            public Dictionary<string, string> TemplateVariable { get; set; } = new();
        }
    }
}
