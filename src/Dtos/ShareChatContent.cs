using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 分享群名片消息
    /// </summary>
    public record ShareChatContent : MessageContent
    {
        /// <summary>
        /// 群名片Id
        /// </summary>
        [JsonPropertyName("share_chat_id")]
        public string ShareChatId { get; set; } = string.Empty;
    }
}
