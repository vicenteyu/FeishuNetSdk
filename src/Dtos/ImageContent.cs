using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    public record ImageContent : MessageContent
    {
        /// <summary>
        /// 其中image key需要通过上传图片接口取得
        /// </summary>
        [JsonPropertyName("image_key")]
        public string ImageKey { get; set; } = string.Empty;
    }
}
