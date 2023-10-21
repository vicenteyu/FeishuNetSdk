using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新任务 响应体
/// <para>该接口用于修改任务的标题、描述、截止时间等信息。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`task`字段中填写要修改的字段的新值即可。如果`update_fields`中设置了要变更一个字段的名字，但是task里没设置新的值，则表示将该字段清空。调用约定详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>目前支持更新的字段包括：</para>
/// <para>* `summary` - 任务标题</para>
/// <para>* `description` - 任务描述</para>
/// <para>* `start` - 任务开始时间</para>
/// <para>* `due` - 任务截止时间</para>
/// <para>* `completed_at` - 用于标记任务完成/未完成</para>
/// <para>* `extra` - 任务附带自定义数据</para>
/// <para>* `custom_complete` - 任务自定义完成配置。</para>
/// <para>* `repeat_rule` -  重复任务规则。</para>
/// <para>* `mode` - 任务完成模式。</para>
/// <para>* `is_milestone` - 是否是里程碑任务。</para>
/// <para>* `custom_fields` - 自定义字段值。</para>
/// <para>该接口可以用于完成任务和将任务恢复至未完成，只需要修改`completed_at`字段即可。但留意，目前不管任务本身是会签任务还是或签任务，oapi对任务进行完成只能实现“整体完成”，不支持个人单独完成。此外，不能对已经完成的任务再次完成，但可以将其恢复到未完成的状态(设置`completed_at`为"0")。</para>
/// <para>如更新自定义字段的值，需要调用身份同时拥有任务的编辑权限和自定义字段的编辑权限。详情见[自定义字段功能概览](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)。更新时，只有填写在`task.custom_fields`的自定义字段值会被更新，不填写的不会被改变。</para>
/// <para>任务成员/提醒/清单数据不能使用本接口进行更新。</para>
/// <para>* 如要修改任务成员，需要使用[添加任务成员](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_members)</para>
/// <para>和[移除任务成员](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_members)接口。</para>
/// <para>* 如要修改任务提醒，需要使用[添加任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_reminders)和[移除任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders)接口。</para>
/// <para>* 如要变更任务所在的清单，需要使用[任务加入清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist)和[任务移出清单]( https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist)接口。</para>
/// <para>接口ID：7255580838154879004</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fpatch</para>
/// </summary>
public record PatchTaskV2TasksByTaskGuidResponseDto
{
    /// <summary>
    /// <para>更新后的任务</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task")]
    public PatchTaskV2TasksByTaskGuidResponseDtoTask? Task { get; set; }

    /// <summary>
    /// <para>更新后的任务</para>
    /// </summary>
    public record PatchTaskV2TasksByTaskGuidResponseDtoTask
    {
        /// <summary>
        /// <para>任务guid，任务的唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>任务标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：进行销售年中总结</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>任务描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：进行销售年中总结</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>任务截止时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("due")]
        public PatchTaskV2TasksByTaskGuidResponseDtoTaskDue? Due { get; set; }

        /// <summary>
        /// <para>任务截止时间</para>
        /// </summary>
        public record PatchTaskV2TasksByTaskGuidResponseDtoTaskDue
        {
            /// <summary>
            /// <para>截止时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果截止时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonProperty("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否截止到一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>任务的提醒配置列表。目前每个任务最多有1个。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("reminders")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>相对于截止时间的提醒时间分钟数。例如30表示截止时间前30分钟提醒；0表示截止时提醒。</para>
            /// <para>必填：是</para>
            /// <para>示例值：30</para>
            /// </summary>
            [JsonProperty("relative_fire_minute")]
            public int RelativeFireMinute { get; set; }
        }

        /// <summary>
        /// <para>任务创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("creator")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>任务角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：assignee</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>任务成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("members")]
        public Member[]? Members { get; set; }

        /// <summary>
        /// <para>任务完成的时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// <para>任务的附件列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("attachments")]
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
            [JsonProperty("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>附件在云文档系统中的token</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxcnTDqPaRA6JbYnzQsZ2doB2b</para>
            /// </summary>
            [JsonProperty("file_token")]
            public string? FileToken { get; set; }

            /// <summary>
            /// <para>附件名</para>
            /// <para>必填：否</para>
            /// <para>示例值：foo.jpg</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>附件的字节大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：62232</para>
            /// </summary>
            [JsonProperty("size")]
            public int? Size { get; set; }

            /// <summary>
            /// <para>附件归属的资源</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("resource")]
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
                [JsonProperty("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>资源ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>附件上传者</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("uploader")]
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
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>成员的类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：user</para>
                /// <para>默认值：user</para>
                /// </summary>
                [JsonProperty("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>任务角色</para>
                /// <para>必填：否</para>
                /// <para>示例值：editor</para>
                /// <para>最大长度：20</para>
                /// </summary>
                [JsonProperty("role")]
                public string? Role { get; set; }
            }

            /// <summary>
            /// <para>是否是封面图</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_cover")]
            public bool? IsCover { get; set; }

            /// <summary>
            /// <para>上传时间戳(ms)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675742789470</para>
            /// </summary>
            [JsonProperty("uploaded_at")]
            public string? UploadedAt { get; set; }
        }

        /// <summary>
        /// <para>任务关联的第三方平台来源信息。创建是设置后就不可更改。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("origin")]
        public PatchTaskV2TasksByTaskGuidResponseDtoTaskOrigin? Origin { get; set; }

        /// <summary>
        /// <para>任务关联的第三方平台来源信息。创建是设置后就不可更改。</para>
        /// </summary>
        public record PatchTaskV2TasksByTaskGuidResponseDtoTaskOrigin
        {
            /// <summary>
            /// <para>任务导入来源的名称，用于在任务中心详情页展示。需提供多语言版本。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("platform_i18n_name")]
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
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }

                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作台</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>中文（香港地区）</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作臺</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonProperty("zh_hk")]
                public string? ZhHk { get; set; }

                /// <summary>
                /// <para>中文（台湾地区）</para>
                /// <para>必填：否</para>
                /// <para>示例值：工作臺</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonProperty("zh_tw")]
                public string? ZhTw { get; set; }

                /// <summary>
                /// <para>日语</para>
                /// <para>必填：否</para>
                /// <para>示例值：作業台</para>
                /// <para>最大长度：1000</para>
                /// </summary>
                [JsonProperty("ja_jp")]
                public string? JaJp { get; set; }

                /// <summary>
                /// <para>法语</para>
                /// <para>必填：否</para>
                /// <para>示例值：Tabledetravail</para>
                /// </summary>
                [JsonProperty("fr_fr")]
                public string? FrFr { get; set; }

                /// <summary>
                /// <para>意大利语</para>
                /// <para>必填：否</para>
                /// <para>示例值：bancodilavoro</para>
                /// </summary>
                [JsonProperty("it_it")]
                public string? ItIt { get; set; }

                /// <summary>
                /// <para>德语</para>
                /// <para>必填：否</para>
                /// <para>示例值：Werkbank</para>
                /// </summary>
                [JsonProperty("de_de")]
                public string? DeDe { get; set; }

                /// <summary>
                /// <para>俄语</para>
                /// <para>必填：否</para>
                /// <para>示例值：верстак</para>
                /// </summary>
                [JsonProperty("ru_ru")]
                public string? RuRu { get; set; }

                /// <summary>
                /// <para>泰语</para>
                /// <para>必填：否</para>
                /// <para>示例值：โต๊ะทำงาน</para>
                /// </summary>
                [JsonProperty("th_th")]
                public string? ThTh { get; set; }

                /// <summary>
                /// <para>西班牙语</para>
                /// <para>必填：否</para>
                /// <para>示例值：bancodetrabajo</para>
                /// </summary>
                [JsonProperty("es_es")]
                public string? EsEs { get; set; }

                /// <summary>
                /// <para>韩语</para>
                /// <para>必填：否</para>
                /// <para>示例值：작업대</para>
                /// </summary>
                [JsonProperty("ko_kr")]
                public string? KoKr { get; set; }
            }

            /// <summary>
            /// <para>任务关联的来源平台详情页链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("href")]
            public PatchTaskV2TasksByTaskGuidResponseDtoTaskOriginHref? Href { get; set; }

            /// <summary>
            /// <para>任务关联的来源平台详情页链接</para>
            /// </summary>
            public record PatchTaskV2TasksByTaskGuidResponseDtoTaskOriginHref
            {
                /// <summary>
                /// <para>链接对应的地址，如填写必须以https://或http://开头</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// <para>最大长度：1024</para>
                /// </summary>
                [JsonProperty("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>链接对应的标题</para>
                /// <para>必填：否</para>
                /// <para>示例值：反馈一个问题，需要协助排查</para>
                /// <para>最大长度：512</para>
                /// </summary>
                [JsonProperty("title")]
                public string? Title { get; set; }
            }
        }

        /// <summary>
        /// <para>任务附带的自定义数据。</para>
        /// <para>必填：否</para>
        /// <para>示例值：dGVzdA==</para>
        /// <para>最大长度：65536</para>
        /// </summary>
        [JsonProperty("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// <para>任务所属清单的名字。调用者只能看到有权限访问的清单的列表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tasklists")]
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
            [JsonProperty("tasklist_guid")]
            public string? TasklistGuid { get; set; }

            /// <summary>
            /// <para>任务所在清单的自定义分组guid</para>
            /// <para>必填：否</para>
            /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
            /// </summary>
            [JsonProperty("section_guid")]
            public string? SectionGuid { get; set; }
        }

        /// <summary>
        /// <para>如果任务为重复任务，返回重复任务的配置</para>
        /// <para>必填：否</para>
        /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
        /// <para>最大长度：500</para>
        /// </summary>
        [JsonProperty("repeat_rule")]
        public string? RepeatRule { get; set; }

        /// <summary>
        /// <para>如果当前任务为某个任务的子任务，返回父任务的guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
        /// </summary>
        [JsonProperty("parent_task_guid")]
        public string? ParentTaskGuid { get; set; }

        /// <summary>
        /// <para>任务的模式。1 - 会签任务；2 - 或签任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("mode")]
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
        [JsonProperty("source")]
        public int? Source { get; set; }

        /// <summary>
        /// <para>任务的自定义完成配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_complete")]
        public PatchTaskV2TasksByTaskGuidResponseDtoTaskCustomComplete? CustomComplete { get; set; }

        /// <summary>
        /// <para>任务的自定义完成配置</para>
        /// </summary>
        public record PatchTaskV2TasksByTaskGuidResponseDtoTaskCustomComplete
        {
            /// <summary>
            /// <para>pc客户端自定义完成配置（含mac和windows）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("pc")]
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
                [JsonProperty("href")]
                public string? Href { get; set; }

                /// <summary>
                /// <para>自定义完成的弹出提示为</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("tip")]
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
                    [JsonProperty("en_us")]
                    public string? EnUs { get; set; }

                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作台</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonProperty("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>中文（香港地区）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作臺</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonProperty("zh_hk")]
                    public string? ZhHk { get; set; }

                    /// <summary>
                    /// <para>中文（台湾地区）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：工作臺</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonProperty("zh_tw")]
                    public string? ZhTw { get; set; }

                    /// <summary>
                    /// <para>日语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：作業台</para>
                    /// <para>最大长度：1000</para>
                    /// </summary>
                    [JsonProperty("ja_jp")]
                    public string? JaJp { get; set; }

                    /// <summary>
                    /// <para>法语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Tabledetravail</para>
                    /// </summary>
                    [JsonProperty("fr_fr")]
                    public string? FrFr { get; set; }

                    /// <summary>
                    /// <para>意大利语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：bancodilavoro</para>
                    /// </summary>
                    [JsonProperty("it_it")]
                    public string? ItIt { get; set; }

                    /// <summary>
                    /// <para>德语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Werkbank</para>
                    /// </summary>
                    [JsonProperty("de_de")]
                    public string? DeDe { get; set; }

                    /// <summary>
                    /// <para>俄语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：верстак</para>
                    /// </summary>
                    [JsonProperty("ru_ru")]
                    public string? RuRu { get; set; }

                    /// <summary>
                    /// <para>泰语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：โต๊ะทำงาน</para>
                    /// </summary>
                    [JsonProperty("th_th")]
                    public string? ThTh { get; set; }

                    /// <summary>
                    /// <para>西班牙语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：bancodetrabajo</para>
                    /// </summary>
                    [JsonProperty("es_es")]
                    public string? EsEs { get; set; }

                    /// <summary>
                    /// <para>韩语</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：작업대</para>
                    /// </summary>
                    [JsonProperty("ko_kr")]
                    public string? KoKr { get; set; }
                }
            }

            /// <summary>
            /// <para>ios端的自定义完成配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("ios")]
            public CustomCompleteItem? Ios { get; set; }

            /// <summary>
            /// <para>android端的自定义完成配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("android")]
            public CustomCompleteItem? Android { get; set; }
        }

        /// <summary>
        /// <para>任务界面上的代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：t6272302</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>任务创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>任务最后一次更新的时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>任务的状态，支持"todo"和"done"两种状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：todo</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>任务的分享链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/todo/detail?guid=70577c8f-91ab-4c91-b359-a21a751054e8&suite_entity_num=t192012</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>任务的开始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("start")]
        public PatchTaskV2TasksByTaskGuidResponseDtoTaskStart? Start { get; set; }

        /// <summary>
        /// <para>任务的开始时间</para>
        /// </summary>
        public record PatchTaskV2TasksByTaskGuidResponseDtoTaskStart
        {
            /// <summary>
            /// <para>开始时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果开始时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonProperty("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否开始于一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>该任务的子任务的个数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("subtask_count")]
        public int? SubtaskCount { get; set; }

        /// <summary>
        /// <para>是否是里程碑任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_milestone")]
        public bool? IsMilestone { get; set; }

        /// <summary>
        /// <para>任务的自定义字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_fields")]
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
            [JsonProperty("guid")]
            public string? Guid { get; set; }

            /// <summary>
            /// <para>自定义字段类型，支持"member", "datetime", "number", "single_select", "multi_select"五种类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：number</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>数字类型的自定义字段值，填写一个合法数字的字符串表示，空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.23</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("number_value")]
            public string? NumberValue { get; set; }

            /// <summary>
            /// <para>日期类型自定义字段值。可以输入一个表示日期的以毫秒为单位的字符串。设为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1687708260000</para>
            /// </summary>
            [JsonProperty("datetime_value")]
            public string? DatetimeValue { get; set; }

            /// <summary>
            /// <para>人员类型的自定义字段值，可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当该字段的设置为“不能多选”时只能输入一个值。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonProperty("member_value")]
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
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>成员的类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：user</para>
                /// <para>默认值：user</para>
                /// </summary>
                [JsonProperty("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>成员角色</para>
                /// <para>必填：否</para>
                /// <para>示例值：editor</para>
                /// <para>最大长度：20</para>
                /// </summary>
                [JsonProperty("role")]
                public string? Role { get; set; }
            }

            /// <summary>
            /// <para>单选类型字段值，填写一个字段选项的option_guid。设置为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：4216f79b-3fda-4dc6-a0c4-a16022e47152</para>
            /// </summary>
            [JsonProperty("single_select_value")]
            public string? SingleSelectValue { get; set; }

            /// <summary>
            /// <para>多选类型字段值，可以填写一个或多个本字段的option_guid。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonProperty("multi_select_value")]
            public string[]? MultiSelectValue { get; set; }

            /// <summary>
            /// <para>自定义字段名</para>
            /// <para>必填：否</para>
            /// <para>示例值：优先级</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>文本类型字段值。可以输入一段文本。空字符串表示清空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一段文本介绍。</para>
            /// </summary>
            [JsonProperty("text_value")]
            public string? TextValue { get; set; }
        }

        /// <summary>
        /// <para>任务依赖</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("dependencies")]
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
            [JsonProperty("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>依赖任务的GUID</para>
            /// <para>必填：是</para>
            /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
            /// </summary>
            [JsonProperty("task_guid")]
            public string TaskGuid { get; set; } = string.Empty;
        }
    }
}
