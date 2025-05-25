// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV2TasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列取任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 列取任务列表 响应体
/// <para>基于调用身份，列出特定类型的所有任务。支持分页。</para>
/// <para>目前只支持列取任务界面上“我负责的”任务。返回的任务数据按照任务在”我负责的“界面中”自定义拖拽“的顺序排序。</para>
/// <para>接口ID：7255580838154403868</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2flist</para>
/// </summary>
public record GetTaskV2TasksResponseDto : IPageableResponse<GetTaskV2TasksResponseDto.Task>
{
    /// <summary>
    /// <para>返回的任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Task[]? Items { get; set; }

    /// <summary>
    /// <para>返回的任务列表</para>
    /// </summary>
    public record Task
    {
        /// <summary>
        /// <para>任务guid，任务的唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>任务标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：进行销售年中总结</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>任务备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：进行销售年中总结</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>任务截止时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("due")]
        public TaskDue? Due { get; set; }

        /// <summary>
        /// <para>任务截止时间</para>
        /// </summary>
        public record TaskDue
        {
            /// <summary>
            /// <para>截止时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。</para>
            /// <para>- 如果是截止日期（`is_all_day` 取值为 true），则该时间戳转换为具体时间后，只需精确到天。例如 `1724284800000` 转换为具体时间为 `2024-08-22`。</para>
            /// <para>- 如果是截止时间（`is_all_day` 取值为 false），则该时间戳转换为具体时间后，精确到秒。例如 `1724284800000` 转换为具体时间为 `2024-08-22 08:00:00 UTC+8`。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否截止到一个日期。可能值有：</para>
            /// <para>- true：截止日期，`timestamp` 转换为具体时间后精确到天。</para>
            /// <para>- false：截止时间，`timestamp` 转换为具体时间后精确到秒。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>任务的提醒配置列表。目前每个任务最多有1个。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reminders")]
        public Reminder[]? Reminders { get; set; }

        /// <summary>
        /// <para>任务的提醒配置列表。目前每个任务最多有1个。</para>
        /// </summary>
        public record Reminder
        {
            /// <summary>
            /// <para>提醒时间设置的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>相对于截止时间的提醒时间分钟数。例如30表示截止时间前30分钟提醒；0表示截止时提醒。</para>
            /// <para>**注意**：该参数值可能为负值。例如，在客户端创建的任务未设置具体截止时间，则该任务的截止时间默认为当天 00:00，如果任务提醒时间为当天 18:00，则 `relative_fire_minute` 返回值为 -1080。</para>
            /// <para>必填：是</para>
            /// <para>示例值：30</para>
            /// </summary>
            [JsonPropertyName("relative_fire_minute")]
            public int RelativeFireMinute { get; set; }
        }

        /// <summary>
        /// <para>任务创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>任务创建者</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：assignee</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>任务成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("members")]
        public Member[]? Members { get; set; }

        /// <summary>
        /// <para>任务完成的时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// <para>任务的附件列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attachments")]
        public Attachment[]? Attachments { get; set; }

        /// <summary>
        /// <para>任务的附件列表</para>
        /// </summary>
        public record Attachment
        {
            /// <summary>
            /// <para>附件guid</para>
            /// <para>必填：否</para>
            /// <para>示例值：f860de3e-6881-4ddd-9321-070f36d1af0b</para>
            /// </summary>
            [JsonPropertyName("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>附件在云文档系统中的token</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxcnTDqPaRA6JbYnzQsZ2doB2b</para>
            /// </summary>
            [JsonPropertyName("file_token")]
            public string? FileToken { get; set; }

            /// <summary>
            /// <para>附件名</para>
            /// <para>必填：否</para>
            /// <para>示例值：foo.jpg</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>附件的字节大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：62232</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }

            /// <summary>
            /// <para>附件归属的资源</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resource")]
            public AttachmentResource? Resource { get; set; }

            /// <summary>
            /// <para>附件归属的资源</para>
            /// </summary>
            public record AttachmentResource
            {
                /// <summary>
                /// <para>资源类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：task</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>资源ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>附件上传者</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("uploader")]
            public Member? Uploader { get; set; }

            /// <summary>
            /// <para>附件上传者</para>
            /// </summary>
            public record Member
            {
                /// <summary>
                /// <para>表示member的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
                /// <para>最大长度：100</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>成员的类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：user</para>
                /// <para>默认值：user</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>成员角色</para>
                /// <para>必填：否</para>
                /// <para>示例值：assignee</para>
                /// <para>最大长度：20</para>
                /// </summary>
                [JsonPropertyName("role")]
                public string? Role { get; set; }
            }

            /// <summary>
            /// <para>是否是封面图</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_cover")]
            public bool? IsCover { get; set; }

            /// <summary>
            /// <para>上传时间戳(ms)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675742789470</para>
            /// </summary>
            [JsonPropertyName("uploaded_at")]
            public string? UploadedAt { get; set; }
        }

        /// <summary>
        /// <para>任务关联的第三方平台来源信息。创建是设置后就不可更改。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("origin")]
        public TaskOrigin? Origin { get; set; }

        /// <summary>
        /// <para>任务关联的第三方平台来源信息。创建是设置后就不可更改。</para>
        /// </summary>
        public record TaskOrigin
        {
            /// <summary>
            /// <para>任务导入来源的名称，用于在任务中心详情页展示。需提供多语言版本。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("platform_i18n_name")]
            public I18nText? PlatformI18nName { get; set; }

            /// <summary>
            /// <para>任务导入来源的名称，用于在任务中心详情页展示。需提供多语言版本。</para>
            /// </summary>
            public record I18nText
            {
                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：workbench</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }

                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作台</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>中文（香港地区）</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作臺</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonPropertyName("zh_hk")]
                public string? ZhHk { get; set; }

                /// <summary>
                /// <para>中文（台湾地区）</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作臺</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonPropertyName("zh_tw")]
                public string? ZhTw { get; set; }

                /// <summary>
                /// <para>日语</para>
                /// <para>必填：否</para>
                /// <para>示例值：作業台</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonPropertyName("ja_jp")]
                public string? JaJp { get; set; }

                /// <summary>
                /// <para>法语</para>
                /// <para>必填：否</para>
                /// <para>示例值：Table de travail</para>
                /// </summary>
                [JsonPropertyName("fr_fr")]
                public string? FrFr { get; set; }

                /// <summary>
                /// <para>意大利语</para>
                /// <para>必填：否</para>
                /// <para>示例值：banco di lavoro</para>
                /// </summary>
                [JsonPropertyName("it_it")]
                public string? ItIt { get; set; }

                /// <summary>
                /// <para>德语</para>
                /// <para>必填：否</para>
                /// <para>示例值：Werkbank</para>
                /// </summary>
                [JsonPropertyName("de_de")]
                public string? DeDe { get; set; }

                /// <summary>
                /// <para>俄语</para>
                /// <para>必填：否</para>
                /// <para>示例值：верстак</para>
                /// </summary>
                [JsonPropertyName("ru_ru")]
                public string? RuRu { get; set; }

                /// <summary>
                /// <para>泰语</para>
                /// <para>必填：否</para>
                /// <para>示例值：โต๊ะทำงาน</para>
                /// </summary>
                [JsonPropertyName("th_th")]
                public string? ThTh { get; set; }

                /// <summary>
                /// <para>西班牙语</para>
                /// <para>必填：否</para>
                /// <para>示例值：banco de trabajo</para>
                /// </summary>
                [JsonPropertyName("es_es")]
                public string? EsEs { get; set; }

                /// <summary>
                /// <para>韩语</para>
                /// <para>必填：否</para>
                /// <para>示例值：작업대</para>
                /// </summary>
                [JsonPropertyName("ko_kr")]
                public string? KoKr { get; set; }
            }

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
                /// <para>链接对应的地址</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
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
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }
            }
        }

        /// <summary>
        /// <para>任务附带的自定义数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：dGVzdA==</para>
        /// <para>最大长度：65536</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>任务所属清单的名字。调用者只能看到有权限访问的清单的列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasklists")]
        public TaskInTasklistInfo[]? Tasklists { get; set; }

        /// <summary>
        /// <para>任务所属清单的名字。调用者只能看到有权限访问的清单的列表。</para>
        /// </summary>
        public record TaskInTasklistInfo
        {
            /// <summary>
            /// <para>任务所在清单的guid</para>
            /// <para>必填：否</para>
            /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("tasklist_guid")]
            public string? TasklistGuid { get; set; }

            /// <summary>
            /// <para>任务所在清单的自定义分组guid</para>
            /// <para>必填：否</para>
            /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
            /// </summary>
            [JsonPropertyName("section_guid")]
            public string? SectionGuid { get; set; }
        }

        /// <summary>
        /// <para>如果任务为重复任务，返回重复任务的配置</para>
        /// <para>必填：否</para>
        /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
        /// <para>最大长度：500</para>
        /// </summary>
        [JsonPropertyName("repeat_rule")]
        public string? RepeatRule { get; set; }

        /// <summary>
        /// <para>如果当前任务为某个任务的子任务，返回父任务的guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
        /// </summary>
        [JsonPropertyName("parent_task_guid")]
        public string? ParentTaskGuid { get; set; }

        /// <summary>
        /// <para>任务的模式。1 - 会签任务；2 - 或签任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>最大值：2</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>任务创建的来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知来源</item>
        /// <item>1：任务中心</item>
        /// <item>2：群组任务/消息转任务</item>
        /// <item>6：通过开放平台以tenant_access_token授权创建的任务</item>
        /// <item>7：通过开放平台以user_access_token授权创建的任务</item>
        /// <item>8：文档任务</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// <para>任务的自定义完成配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_complete")]
        public TaskCustomComplete? CustomComplete { get; set; }

        /// <summary>
        /// <para>任务的自定义完成配置</para>
        /// </summary>
        public record TaskCustomComplete
        {
            /// <summary>
            /// <para>pc客户端自定义完成配置（含mac和windows）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("pc")]
            public CustomCompleteItem? Pc { get; set; }

            /// <summary>
            /// <para>pc客户端自定义完成配置（含mac和windows）</para>
            /// </summary>
            public record CustomCompleteItem
            {
                /// <summary>
                /// <para>自定义完成的跳转url</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("href")]
                public string? Href { get; set; }

                /// <summary>
                /// <para>自定义完成的弹出提示为</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("tip")]
                public I18nText? Tip { get; set; }

                /// <summary>
                /// <para>自定义完成的弹出提示为</para>
                /// </summary>
                public record I18nText
                {
                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：workbench</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }

                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作台</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>中文（香港地区）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作臺</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonPropertyName("zh_hk")]
                    public string? ZhHk { get; set; }

                    /// <summary>
                    /// <para>中文（台湾地区）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作臺</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonPropertyName("zh_tw")]
                    public string? ZhTw { get; set; }

                    /// <summary>
                    /// <para>日语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：作業台</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonPropertyName("ja_jp")]
                    public string? JaJp { get; set; }

                    /// <summary>
                    /// <para>法语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Table de travail</para>
                    /// </summary>
                    [JsonPropertyName("fr_fr")]
                    public string? FrFr { get; set; }

                    /// <summary>
                    /// <para>意大利语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：banco di lavoro</para>
                    /// </summary>
                    [JsonPropertyName("it_it")]
                    public string? ItIt { get; set; }

                    /// <summary>
                    /// <para>德语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Werkbank</para>
                    /// </summary>
                    [JsonPropertyName("de_de")]
                    public string? DeDe { get; set; }

                    /// <summary>
                    /// <para>俄语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：верстак</para>
                    /// </summary>
                    [JsonPropertyName("ru_ru")]
                    public string? RuRu { get; set; }

                    /// <summary>
                    /// <para>泰语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：โต๊ะทำงาน</para>
                    /// </summary>
                    [JsonPropertyName("th_th")]
                    public string? ThTh { get; set; }

                    /// <summary>
                    /// <para>西班牙语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：banco de trabajo</para>
                    /// </summary>
                    [JsonPropertyName("es_es")]
                    public string? EsEs { get; set; }

                    /// <summary>
                    /// <para>韩语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：작업대</para>
                    /// </summary>
                    [JsonPropertyName("ko_kr")]
                    public string? KoKr { get; set; }
                }
            }

            /// <summary>
            /// <para>ios端的自定义完成配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ios")]
            public CustomCompleteItem? Ios { get; set; }

            /// <summary>
            /// <para>android端的自定义完成配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("android")]
            public CustomCompleteItem? Android { get; set; }
        }

        /// <summary>
        /// <para>任务界面上的代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：t6272302</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>任务创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>任务最后一次更新的时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>任务的状态，支持"todo"和"done"两种状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：todo</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>任务的分享链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/todo/detail?guid=70577c8f-91ab-4c91-b359-a21a751054e8&amp;suite_entity_num=t192012</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>任务的开始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start")]
        public TaskStart? Start { get; set; }

        /// <summary>
        /// <para>任务的开始时间</para>
        /// </summary>
        public record TaskStart
        {
            /// <summary>
            /// <para>开始时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果开始时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonPropertyName("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否开始于一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>该任务的子任务的个数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("subtask_count")]
        public int? SubtaskCount { get; set; }

        /// <summary>
        /// <para>是否是里程碑任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_milestone")]
        public bool? IsMilestone { get; set; }

        /// <summary>
        /// <para>任务的自定义字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldValue[]? CustomFields { get; set; }

        /// <summary>
        /// <para>任务的自定义字段值</para>
        /// </summary>
        public record CustomFieldValue
        {
            /// <summary>
            /// <para>字段GUID</para>
            /// <para>必填：否</para>
            /// <para>示例值：a4f648d7-76ef-477f-bc8e-0601b5a60093</para>
            /// </summary>
            [JsonPropertyName("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>自定义字段类型，支持"member", "datetime", "number", "single_select", "multi_select"五种类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：number</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>数字类型的自定义字段值，填写一个合法数字的字符串表示，空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.23</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("number_value")]
            public string? NumberValue { get; set; }

            /// <summary>
            /// <para>日期类型自定义字段值。可以输入一个表示日期的以毫秒为单位的字符串。设为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1687708260000</para>
            /// </summary>
            [JsonPropertyName("datetime_value")]
            public string? DatetimeValue { get; set; }

            /// <summary>
            /// <para>人员类型的自定义字段值，可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当该字段的设置为“不能多选”时只能输入一个值。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("member_value")]
            public Member[]? MemberValues { get; set; }

            /// <summary>
            /// <para>人员类型的自定义字段值，可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当该字段的设置为“不能多选”时只能输入一个值。设为空数组表示设为空。</para>
            /// </summary>
            public record Member
            {
                /// <summary>
                /// <para>表示member的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
                /// <para>最大长度：100</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>成员的类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：user</para>
                /// <para>默认值：user</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>成员角色</para>
                /// <para>必填：否</para>
                /// <para>示例值：editor</para>
                /// <para>最大长度：20</para>
                /// </summary>
                [JsonPropertyName("role")]
                public string? Role { get; set; }
            }

            /// <summary>
            /// <para>单选类型字段值，填写一个字段选项的option_guid。设置为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：4216f79b-3fda-4dc6-a0c4-a16022e47152</para>
            /// </summary>
            [JsonPropertyName("single_select_value")]
            public string? SingleSelectValue { get; set; }

            /// <summary>
            /// <para>多选类型字段值，可以填写一个或多个本字段的option_guid。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("multi_select_value")]
            public string[]? MultiSelectValue { get; set; }

            /// <summary>
            /// <para>自定义字段名</para>
            /// <para>必填：否</para>
            /// <para>示例值：优先级</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>任务依赖</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dependencies")]
        public TaskDependency[]? Dependencies { get; set; }

        /// <summary>
        /// <para>任务依赖</para>
        /// </summary>
        public record TaskDependency
        {
            /// <summary>
            /// <para>依赖类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：next</para>
            /// <para>可选值：<list type="bullet">
            /// <item>prev：前置依赖</item>
            /// <item>next：后置依赖</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>依赖任务的GUID</para>
            /// <para>必填：是</para>
            /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
            /// </summary>
            [JsonPropertyName("task_guid")]
            public string TaskGuid { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
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
