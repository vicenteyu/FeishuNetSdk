// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV1TasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询所有任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 查询所有任务 响应体
/// <para>以分页的方式获取任务列表。当使用user_access_token时，获取与该用户身份相关的所有任务。当使用tenant_access_token时，获取以该应用身份通过“创建任务“接口创建的所有任务（并非获取该应用所在租户下所有用户创建的任务）。</para>
/// <para>本接口支持通过任务创建时间以及任务的完成状态对任务进行过滤。</para>
/// <para>接口ID：7044355281854070812</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2flist</para>
/// </summary>
public record GetTaskV1TasksResponseDto : IPageableResponse<GetTaskV1TasksResponseDto.Task>
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Task[]? Items { get; set; }

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record Task
    {
        /// <summary>
        /// <para>任务的唯一ID，例如"83912691-2e43-47fc-94a4-d512e03984fa"</para>
        /// <para>必填：否</para>
        /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>任务的标题，类型为文本字符串。</para>
        /// <para>如果要在任务标题中插入 URL 或者 @某个用户，请使用rich_summary字段。</para>
        /// <para>创建任务时，任务标题(summary字段)和任务富文本标题(rich_summary字段)不能同时为空，需要至少填充其中一个字段。</para>
        /// <para>任务标题和任务富文本标题同时存在时只使用富文本标题。</para>
        /// <para>必填：否</para>
        /// <para>示例值：每天喝八杯水，保持身心愉悦</para>
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
        /// <para>示例值：多吃水果，多运动，健康生活，快乐工作。</para>
        /// <para>最大长度：65536</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>任务的完成时间戳（单位为秒），完成时间为0则表示任务尚未完成。</para>
        /// <para>不支持部分完成，只有整个任务完成，该字段才会有非0值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1623499200</para>
        /// </summary>
        [JsonPropertyName("complete_time")]
        public string? CompleteTime { get; set; }

        /// <summary>
        /// <para>任务的创建者 ID。</para>
        /// <para>其中查询字段 user_id_type 是用于控制返回体中 creator_id 的类型，不传时默认返回 open_id。</para>
        /// <para>特别的，使用tenant_access_token 调用接口时，如果是user_id_type是openid，则返回代表该应用身份的openid；当user_id_type为user_id时，不返回creator_id。原因是user_id代表一个真实飞书用户的id，应用身份没有user_id。使用user_access_token调用接口正常返回创建者。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f346a</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

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
        /// <para>任务的创建时间的Unix时间戳（单位为秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1623392486</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>任务的更新时间的Unix时间戳（单位为秒）</para>
        /// <para>创建任务时update_time与create_time相同</para>
        /// <para>必填：否</para>
        /// <para>示例值：1623392486</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>任务的截止时间设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("due")]
        public TaskDue? Due { get; set; }

        /// <summary>
        /// <para>任务的截止时间设置</para>
        /// </summary>
        public record TaskDue
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
        public TaskOrigin Origin { get; set; } = new();

        /// <summary>
        /// <para>任务关联的第三方平台来源信息</para>
        /// </summary>
        public record TaskOrigin
        {
            /// <summary>
            /// <para>任务来源的名称。</para>
            /// <para>用于在任务中心详情页展示。需要提供一个字典，支持多种语言名称映射。应用在使用不同语言时，导入来源也将展示对应的内容。详细参见：[任务字段补充说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/Supplementary-directions-of-task-fields)</para>
            /// <para>必填：是</para>
            /// <para>示例值：{"zh_cn": "IT 工作台", "en_us": "IT Workspace"}</para>
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
            public TaskOriginHref? Href { get; set; }

            /// <summary>
            /// <para>任务关联的来源平台详情页链接</para>
            /// </summary>
            public record TaskOriginHref
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
        /// <para>任务创建的来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知类型</item>
        /// <item>1：来源任务中心创建</item>
        /// <item>2：来源消息转任务</item>
        /// <item>3：来源云文档</item>
        /// <item>4：来源文档单品</item>
        /// <item>5：来源PANO</item>
        /// <item>6：来源tenant_access_token创建的任务</item>
        /// <item>7：来源user_access_token创建的任务</item>
        /// <item>8：来源新版云文档</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// <para>任务的关注者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_03c21c80caea2c816665f8056dc59027</para>
        /// </summary>
        [JsonPropertyName("followers")]
        public Follower[]? Followers { get; set; }

        /// <summary>
        /// <para>任务的关注者</para>
        /// </summary>
        public record Follower
        {
            /// <summary>
            /// <para>任务关注人 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f3123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>要删除的关注人ID列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_list")]
            public string[]? IdList { get; set; }
        }

        /// <summary>
        /// <para>任务的执行者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_558d4999baae26e32aa2fd9bb228660b</para>
        /// </summary>
        [JsonPropertyName("collaborators")]
        public Collaborator[]? Collaborators { get; set; }

        /// <summary>
        /// <para>任务的执行者</para>
        /// </summary>
        public record Collaborator
        {
            /// <summary>
            /// <para>任务执行者的 ID。</para>
            /// <para>传入的值为 user_id 或 open_id，由user_id_type 决定。user_id和open_id的获取可见文档[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
            /// <para>已经废弃，为了向前兼容早期只支持单次添加一个人的情况而保留，但不再推荐使用，建议使用id_list字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f1234</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>执行者的用户ID列表。</para>
            /// <para>传入的值为 user_id 或 open_id，由user_id_type 决定。user_id和open_id的获取可见文档[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id_list")]
            public string[]? IdList { get; set; }
        }

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
        /// <para>示例值：每天喝八杯水，保持身心愉悦。[谷歌](https://www.google.com/)</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("rich_summary")]
        public string? RichSummary { get; set; }

        /// <summary>
        /// <para>富文本任务备注。语法格式参见[Markdown模块](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/markdown-module)</para>
        /// <para>必填：否</para>
        /// <para>示例值：多吃水果，多运动，健康生活，快乐工作。[谷歌](https://www.google.com/)</para>
        /// <para>最大长度：65536</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("rich_description")]
        public string? RichDescription { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
