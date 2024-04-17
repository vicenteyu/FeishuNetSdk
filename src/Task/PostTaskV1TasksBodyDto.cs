namespace FeishuNetSdk.Task;
/// <summary>
/// 创建任务 请求体
/// <para>该接口可以创建一个任务，支持填写任务的基本信息，包括任务的标题，描述及协作者等。</para>
/// <para>在此基础上，创建任务时可以设置截止时间和重复规则，将任务设置为定期执行的重复任务。通过添加协作者，则可以让其他用户协同完成该任务。</para>
/// <para>此外，接口也提供了一些支持自定义内容的字段，调用方可以实现定制化效果，如完成任务后跳转到指定结束界面。</para>
/// <para>接口ID：6985127383322296322</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fcreate</para>
/// </summary>
public record PostTaskV1TasksBodyDto
{
    /// <summary>
    /// <para>任务的标题，类型为文本字符串。</para>
    /// <para>如果要在任务标题中插入 URL 或者 @某个用户，请使用rich_summary字段。</para>
    /// <para>创建任务时，任务标题(summary字段)和任务富文本标题(rich_summary字段)不能同时为空，需要至少填充其中一个字段。</para>
    /// <para>任务标题和任务富文本标题同时存在时只使用富文本标题。</para>
    /// <para>必填：否</para>
    /// <para>示例值：完成本季度OKR编写</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>任务的描述，类型为文本字符串。</para>
    /// <para>如果要在任务描述中插入 URL 或者 @某个用户，请使用rich_description字段。</para>
    /// <para>任务备注和任务富文本备注同时存在时只使用富文本备注。</para>
    /// <para>必填：否</para>
    /// <para>示例值：对本次会议内容复盘总结，编写更新本季度OKR</para>
    /// <para>最大长度：65536</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>附属信息。</para>
    /// <para>接入方可以传入base64 编码后的自定义的数据。用户如果需要对当前任务备注信息，但对外不显示，可使用该字段进行存储。</para>
    /// <para>该数据会在获取任务详情时，原样返回给用户。</para>
    /// <para>必填：否</para>
    /// <para>示例值：dGVzdA==</para>
    /// <para>最大长度：65536</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>任务的截止时间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("due")]
    public PostTaskV1TasksBodyDtoDue? Due { get; set; }

    /// <summary>
    /// <para>任务的截止时间设置</para>
    /// </summary>
    public record PostTaskV1TasksBodyDtoDue
    {
        /// <summary>
        /// <para>表示截止时间的Unix时间戳（单位为秒）。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1623124318</para>
        /// </summary>
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// <para>截止时间对应的时区。</para>
        /// <para>传入值需要符合IANA Time Zone Database标准，规范见[Time Zone Database](https://www.iana.org/time-zones)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// <para>默认值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// <para>标记任务是否为全天任务。</para>
        /// <para>包括如下取值：</para>
        /// <para>- true：表示是全天任务，全天任务的截止时间为当天 UTC 时间的 0 点。</para>
        /// <para>- false：表示不是全天任务。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_all_day")]
        public bool? IsAllDay { get; set; }
    }

    /// <summary>
    /// <para>任务关联的第三方平台来源信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("origin")]
    public PostTaskV1TasksBodyDtoOrigin Origin { get; set; } = new();

    /// <summary>
    /// <para>任务关联的第三方平台来源信息</para>
    /// </summary>
    public record PostTaskV1TasksBodyDtoOrigin
    {
        /// <summary>
        /// <para>任务来源的名称。</para>
        /// <para>用于在任务中心详情页展示。需要提供一个字典，支持多种语言名称映射。应用在使用不同语言时，导入来源也将展示对应的内容。详细参见：[任务字段补充说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/Supplementary-directions-of-task-fields)</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"zh_cn\": \"IT 工作台\", \"en_us\": \"IT Workspace\"}</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("platform_i18n_name")]
        public string PlatformI18nName { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务关联的来源平台详情页链接</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("href")]
        public PostTaskV1TasksBodyDtoOriginHref? Href { get; set; }

        /// <summary>
        /// <para>任务关联的来源平台详情页链接</para>
        /// </summary>
        public record PostTaskV1TasksBodyDtoOriginHref
        {
            /// <summary>
            /// <para>具体链接地址。</para>
            /// <para>URL仅支持解析http、https。详细参见：[任务字段补充说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/Supplementary-directions-of-task-fields)</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://support.feishu.com/internal/foo-bar</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>链接对应的标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：反馈一个问题，需要协助排查</para>
            /// <para>最大长度：512</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }
        }
    }

    /// <summary>
    /// <para>此字段用于控制该任务在飞书任务中心是否可编辑，默认为false</para>
    /// <para>已经废弃，向前兼容故仍然保留，但不推荐使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("can_edit")]
    public bool? CanEdit { get; set; }

    /// <summary>
    /// <para>自定义完成配置。</para>
    /// <para>此字段用于设置完成任务时的页面跳转，或展示提示语。详细参见：[任务字段补充说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/Supplementary-directions-of-task-fields)</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"custom_complete\":{\"android\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"ios\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"pc\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}}}}</para>
    /// <para>最大长度：65536</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom")]
    public string? Custom { get; set; }

    /// <summary>
    /// <para>创建任务时添加的执行者用户id列表。</para>
    /// <para>传入的值为 user_id 或 open_id ，由user_id_type 决定。user_id和open_id的获取可见文档：[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_1400208f15333e20e11339d39067844b", "ou_84ed6312949945c8ae6168f10829e9e6"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("collaborator_ids")]
    public string[]? CollaboratorIds { get; set; }

    /// <summary>
    /// <para>创建任务时添加的关注者用户id列表。</para>
    /// <para>传入的值为 user_id 或 open_id ，由user_id_type 决定。user_id和open_id的获取可见文档：[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_1400208f15333e20e11339d39067844b", "ou_84ed6312949945c8ae6168f10829e9e6"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("follower_ids")]
    public string[]? FollowerIds { get; set; }

    /// <summary>
    /// <para>重复任务的规则表达式。</para>
    /// <para>语法格式参见[RRule语法规范](https://www.ietf.org/rfc/rfc2445.txt) 4.3.10小节</para>
    /// <para>必填：否</para>
    /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
    /// </summary>
    [JsonPropertyName("repeat_rule")]
    public string? RepeatRule { get; set; }

    /// <summary>
    /// <para>富文本任务标题。语法格式参见[Markdown模块](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/markdown-module)</para>
    /// <para>。创建任务时，任务标题(summary字段)和任务富文本标题(rich_summary字段)不能同时为空，需要至少填充其中一个字段。</para>
    /// <para>必填：否</para>
    /// <para>示例值：完成本季度OKR编写\[飞书开放平台](https://open.feishu.cn/)</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("rich_summary")]
    public string? RichSummary { get; set; }

    /// <summary>
    /// <para>富文本任务备注。语法格式参见[Markdown模块](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/markdown-module)</para>
    /// <para>必填：否</para>
    /// <para>示例值：对本次会议内容复盘总结，编写更新本季度OKR\[飞书开放平台](https://open.feishu.cn/)</para>
    /// <para>最大长度：65536</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("rich_description")]
    public string? RichDescription { get; set; }
}
