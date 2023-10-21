using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除会话标签页 响应体
/// <para>删除会话标签页。</para>
/// <para>接口ID：7111246605500579841</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/delete_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fdelete_tabs</para>
/// </summary>
public record DeleteImV1ChatsByChatIdChatTabsDeleteTabsResponseDto
{
    /// <summary>
    /// <para>会话标签页</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chat_tabs")]
    public ChatTab[]? ChatTabs { get; set; }

    /// <summary>
    /// <para>会话标签页</para>
    /// </summary>
    public record ChatTab
    {
        /// <summary>
        /// <para>Tab ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7101214603622940671</para>
        /// </summary>
        [JsonProperty("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// <para>Tab名称</para>
        /// <para>**注意**：会话标签页的名称不能超过30个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：文档</para>
        /// </summary>
        [JsonProperty("tab_name")]
        public string? TabName { get; set; }

        /// <summary>
        /// <para>Tab类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>message：消息类型</item>
        /// <item>doc_list：云文档列表</item>
        /// <item>doc：文档</item>
        /// <item>pin：Pin</item>
        /// <item>meeting_minute：会议纪要</item>
        /// <item>chat_announcement：群公告</item>
        /// <item>url：URL</item>
        /// <item>file：文件</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("tab_type")]
        public string TabType { get; set; } = string.Empty;

        /// <summary>
        /// <para>Tab内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tab_content")]
        public ChatTabContent? TabContent { get; set; }

        /// <summary>
        /// <para>Tab内容</para>
        /// </summary>
        public record ChatTabContent
        {
            /// <summary>
            /// <para>URL类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.feishu.cn</para>
            /// </summary>
            [JsonProperty("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>Doc链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.feishu.cn/wiki/wikcnPIcqWjJQwkwDzrB9t40123xz</para>
            /// </summary>
            [JsonProperty("doc")]
            public string? Doc { get; set; }

            /// <summary>
            /// <para>会议纪要</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.feishu.cn/docs/doccnvIXbV22i6hSD3utar4123dx</para>
            /// </summary>
            [JsonProperty("meeting_minute")]
            public string? MeetingMinute { get; set; }
        }

        /// <summary>
        /// <para>Tab的配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tab_config")]
        public ChatTabConfig? TabConfig { get; set; }

        /// <summary>
        /// <para>Tab的配置</para>
        /// </summary>
        public record ChatTabConfig
        {
            /// <summary>
            /// <para>群Tab图标</para>
            /// <para>必填：否</para>
            /// <para>示例值：img_v2_b99741-7628-4abd-aad0-b881e4db83ig</para>
            /// </summary>
            [JsonProperty("icon_key")]
            public string? IconKey { get; set; }

            /// <summary>
            /// <para>群tab是否App内嵌打开</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_built_in")]
            public bool? IsBuiltIn { get; set; }
        }
    }
}
