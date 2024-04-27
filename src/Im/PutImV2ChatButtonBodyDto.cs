namespace FeishuNetSdk.Im;
/// <summary>
/// 更新消息流卡片按钮 请求体
/// <para>为群组消息、机器人消息的消息流卡片添加、更新、删除快捷操作按钮。</para>
/// <para>接口ID：7302258202712506396</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/chat_button/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat_button%2fupdate</para>
/// </summary>
public record PutImV2ChatButtonBodyDto
{
    /// <summary>
    /// <para>用户 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>群 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; } = string.Empty;

    /// <summary>
    /// <para>按钮</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("buttons")]
    public OpenAppFeedCardButtons? Buttons { get; set; }

    /// <summary>
    /// <para>按钮</para>
    /// </summary>
    public record OpenAppFeedCardButtons
    {
        /// <summary>
        /// <para>按钮组合，该字段为全量更新字段，若未传入字段原有值，则会清空字段数据。例如：</para>
        /// <para>- 在保持原有按钮的字段配置的前提下，新增一个按钮配置会添加一个按钮。</para>
        /// <para>- 在原有按钮的字段配置上做更新，会更新该按钮。</para>
        /// <para>- 清空原有按钮的字段配置，会删除该按钮。</para>
        /// <para>必填：是</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("buttons")]
        public OpenAppFeedCardButton[] Buttons { get; set; } = Array.Empty<OpenAppFeedCardButton>();

        /// <summary>
        /// <para>按钮组合，该字段为全量更新字段，若未传入字段原有值，则会清空字段数据。例如：</para>
        /// <para>- 在保持原有按钮的字段配置的前提下，新增一个按钮配置会添加一个按钮。</para>
        /// <para>- 在原有按钮的字段配置上做更新，会更新该按钮。</para>
        /// <para>- 清空原有按钮的字段配置，会删除该按钮。</para>
        /// </summary>
        public record OpenAppFeedCardButton
        {
            /// <summary>
            /// <para>跳转 URL</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("multi_url")]
            public OpenAppFeedCardUrl? MultiUrl { get; set; }

            /// <summary>
            /// <para>跳转 URL</para>
            /// </summary>
            public record OpenAppFeedCardUrl
            {
                /// <summary>
                /// <para>默认 URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/</para>
                /// <para>最大长度：700</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>Android 平台 URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/</para>
                /// <para>最大长度：700</para>
                /// </summary>
                [JsonPropertyName("android_url")]
                public string? AndroidUrl { get; set; }

                /// <summary>
                /// <para>iOS 平台 URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/</para>
                /// <para>最大长度：700</para>
                /// </summary>
                [JsonPropertyName("ios_url")]
                public string? IosUrl { get; set; }

                /// <summary>
                /// <para>PC URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/</para>
                /// <para>最大长度：700</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }
            }

            /// <summary>
            /// <para>交互类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：url_page</para>
            /// <para>可选值：<list type="bullet">
            /// <item>url_page：URL 页面</item>
            /// <item>webhook：回调</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("action_type")]
            public string ActionType { get; set; } = string.Empty;

            /// <summary>
            /// <para>文字</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("text")]
            public OpenAppFeedCardText Text { get; set; } = new();

            /// <summary>
            /// <para>文字</para>
            /// </summary>
            public record OpenAppFeedCardText
            {
                /// <summary>
                /// <para>文本</para>
                /// <para>必填：是</para>
                /// <para>示例值：文本</para>
                /// <para>最大长度：30</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string Text { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>按钮类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：default</para>
            /// <para>可选值：<list type="bullet">
            /// <item>default：默认</item>
            /// <item>primary：主要</item>
            /// <item>success：成功</item>
            /// </list></para>
            /// <para>默认值：default</para>
            /// </summary>
            [JsonPropertyName("button_type")]
            public string? ButtonType { get; set; }

            /// <summary>
            /// <para>action 字典</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"foo": "bar"}</para>
            /// </summary>
            [JsonPropertyName("action_map")]
            public object? ActionMap { get; set; }
        }
    }
}
