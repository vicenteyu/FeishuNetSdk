using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 卡片内容
    /// </summary>
    public record ElementsCardDto
    {
        /// <summary>
        /// 元素集合
        /// </summary>
        [JsonPropertyName("elements")]
        public Element[] Elements { get; set; } = Array.Empty<Element>();

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
}
