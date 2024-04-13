using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    public record TextContent : MessageContent
    {
        /// <summary>
        /// 文本消息
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }
}
