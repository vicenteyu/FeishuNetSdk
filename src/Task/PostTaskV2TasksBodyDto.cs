using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建任务 请求体
/// <para>该接口可以创建一个任务，在创建任务时，支持填写任务的基本信息（如标题、描述、负责人等），此外，还可以设置任务的开始时间、截止时间提醒等条件，此外，还可以通过传入 tasklists 字段将新任务加到多个清单中。</para>
/// <para>创建任务时，可以通过设置`members`字段来设置任务的负责人和关注人。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？ ”章节。</para>
/// <para>如果要设置任务的开始时间和截止时间，需要遵守任务时间的格式和约束。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
/// <para>如要设置自定义字段值，可以设置`custom_fields`字段。但因为自定义字段归属于清单，因此要填写的自定义字段的guid必须归属于要添加的清单(通过`tasklists`设置）。详见[自定义字段概览](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)。</para>
/// <para>通过设置`client_token`实现幂等调用。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 幂等调用 ”章节。</para>
/// <para>如要创建一个任务的子任务，需要使用[创建子任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task-subtask/create)接口。</para>
/// <para>创建任务时可以一并设置自定义字段值。但根据自定义字段的权限关系，任务只能添加`tasklists`字段设置的清单中关联的自定义字段的值。详见[自定义字段功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)中的介绍。</para>
/// <para>接口ID：7255580838154371100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fcreate</para>
/// </summary>
public record PostTaskV2TasksBodyDto
{
    /// <summary>
    /// <para>任务标题。不能为空，支持最大3000个utf8字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：针对全年销售进行一次复盘</para>
    /// </summary>
    [JsonProperty("summary")]
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务摘要。支持最大3000个utf8字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：需要事先阅读复盘总结文档</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>任务截止时间。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1675742789470</para>
    /// </summary>
    [JsonProperty("due")]
    public PostTaskV2TasksBodyDtoDue? Due { get; set; }

    /// <summary>
    /// <para>任务截止时间。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
    /// </summary>
    public record PostTaskV2TasksBodyDtoDue
    {
        /// <summary>
        /// <para>截止时间/日期的时间戳，距1970-01-01 00:00:00 UTC的毫秒数。如果截止时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
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
    /// <para>任务关联的第三方平台来源信息，用于来源信息在飞书任务界面的展示。只能创建任务时设置，一旦设置后就不可变更。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用Origin? ”章节。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("origin")]
    public PostTaskV2TasksBodyDtoOrigin? Origin { get; set; }

    /// <summary>
    /// <para>任务关联的第三方平台来源信息，用于来源信息在飞书任务界面的展示。只能创建任务时设置，一旦设置后就不可变更。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用Origin? ”章节。</para>
    /// </summary>
    public record PostTaskV2TasksBodyDtoOrigin
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
        public PostTaskV2TasksBodyDtoOriginHref? Href { get; set; }

        /// <summary>
        /// <para>任务关联的来源平台详情页链接</para>
        /// </summary>
        public record PostTaskV2TasksBodyDtoOriginHref
        {
            /// <summary>
            /// <para>来源链接对应的地址，如填写必须以https://或者http://开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.example.com</para>
            /// <para>最大长度：1024</para>
            /// </summary>
            [JsonProperty("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>来源链接对应的标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：反馈一个问题，需要协助排查</para>
            /// <para>最大长度：512</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }
        }
    }

    /// <summary>
    /// <para>调用者可以传入的任意附带到任务上的数据。在获取任务详情时会原样返回。如果是二进制数据可以使用Base64编码。</para>
    /// <para>必填：否</para>
    /// <para>示例值：dGVzdA==</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonProperty("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>任务的完成时刻时间戳(ms)。不填写或者设为0表示创建一个未完成任务；填写一个具体的时间戳表示创建一个已完成任务。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1675742789470</para>
    /// <para>最大长度：20</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonProperty("completed_at")]
    public string? CompletedAt { get; set; }

    /// <summary>
    /// <para>任务成员列表，包括负责人和关注人。不填写表示任务无成员。单次请求支持最大50个成员（去重后）。</para>
    /// <para>详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？ ”章节。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("members")]
    public Member[]? Members { get; set; }

    /// <summary>
    /// <para>任务成员列表，包括负责人和关注人。不填写表示任务无成员。单次请求支持最大50个成员（去重后）。</para>
    /// <para>详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？ ”章节。</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>表示member的id</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员的类型，可以是user或者app。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>默认值：user</para>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>成员角色，可以是"assignee"或者"follower"。</para>
        /// <para>必填：是</para>
        /// <para>示例值：assignee</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>重复任务规则。如果设置，则该任务为“重复任务”。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“如何使用重复任务？”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonProperty("repeat_rule")]
    public string? RepeatRule { get; set; }

    /// <summary>
    /// <para>任务自定义完成配置。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“ 如何使用任务自定义完成？”章节。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("custom_complete")]
    public PostTaskV2TasksBodyDtoCustomComplete? CustomComplete { get; set; }

    /// <summary>
    /// <para>任务自定义完成配置。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“ 如何使用任务自定义完成？”章节。</para>
    /// </summary>
    public record PostTaskV2TasksBodyDtoCustomComplete
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
            /// <para>自定义完成的弹出提示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("tip")]
            public I18nText? Tip { get; set; }

            /// <summary>
            /// <para>自定义完成的弹出提示</para>
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
    /// <para>任务所在清单的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tasklists")]
    public TaskInTasklistInfo[]? Tasklists { get; set; }

    /// <summary>
    /// <para>任务所在清单的信息</para>
    /// </summary>
    public record TaskInTasklistInfo
    {
        /// <summary>
        /// <para>指定在某个清单中创建任务，需要该清单的可编辑权限。不填写表示不在清单中创建任务。</para>
        /// <para>必填：否</para>
        /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("tasklist_guid")]
        public string? TasklistGuid { get; set; }

        /// <summary>
        /// <para>清单中自定义分组的GUID，用于指定在某个清单中创建任务的同时把任务加入到某个具体的分组中。如果填写了清单的GUID，却没填写分组的GUID，则自动加入该清单的默认分组中。</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonProperty("section_guid")]
        public string? SectionGuid { get; set; }
    }

    /// <summary>
    /// <para>幂等token。如果提供则触发后端实现幂等行为。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 幂等调用 ”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：daa2237f-8310-4707-a83b-52c8a81e0fb7</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("client_token")]
    public string? ClientToken { get; set; }

    /// <summary>
    /// <para>任务的开始时间(ms), 详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("start")]
    public PostTaskV2TasksBodyDtoStart? Start { get; set; }

    /// <summary>
    /// <para>任务的开始时间(ms), 详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
    /// </summary>
    public record PostTaskV2TasksBodyDtoStart
    {
        /// <summary>
        /// <para>开始时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果开始时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true。</para>
        /// <para>如果同时设置任务的开始时间和截止时间，开始时间必须<=截止时间，并且开始/截止时间的is_all_day设置必须相同。</para>
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
    /// <para>任务提醒。要设置提醒必须同时设置任务的截止时间。一个任务最多只能设置1个提醒。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reminders")]
    public Reminder[]? Reminders { get; set; }

    /// <summary>
    /// <para>任务提醒。要设置提醒必须同时设置任务的截止时间。一个任务最多只能设置1个提醒。</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>相对于截止时间的提醒时间分钟数。例如30表示截止时间前30分钟提醒；0表示截止时提醒。</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonProperty("relative_fire_minute")]
        public int RelativeFireMinute { get; set; }
    }

    /// <summary>
    /// <para>任务完成模式, 1 - 会签任务; 2 - 或签任务</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>默认值：2</para>
    /// </summary>
    [JsonProperty("mode")]
    public int? Mode { get; set; }

    /// <summary>
    /// <para>是否是里程碑任务</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonProperty("is_milestone")]
    public bool? IsMilestone { get; set; }

    /// <summary>
    /// <para>自定义字段值。可以在创建任务的同时设置一个或多个自定义字段的值。要设置值的自定义字段必须关联于任务要加入的清单(通过`tasklists`字段设置），否则将无法设置。</para>
    /// <para>每个字段的值根据字段类型填写相应的字段。</para>
    /// <para>* 当`type`为"number"时，应使用`number_value`字段，表示数字类型自定义字段的值；</para>
    /// <para>* 当`type`为"member"时，应使用`member_value`字段，表示人员类型自定义字段的值；</para>
    /// <para>* 当`type`为"datetime"时，应使用`datetime_value`字段，表示日期类型自定义字段的值；</para>
    /// <para>* 当`type`为"single_select"时，应使用`single_select_value`字段，表示单选类型自定义字段的值；</para>
    /// <para>* 当`type`为"multi_select"时，应使用`multi_select_value`字段，表示多选类型自定义字段的值；</para>
    /// <para>* 当`type`为“text”时，应使用`text_value`字段，表示文本字段类型的值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("custom_fields")]
    public InputCustomFieldValue[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段值。可以在创建任务的同时设置一个或多个自定义字段的值。要设置值的自定义字段必须关联于任务要加入的清单(通过`tasklists`字段设置），否则将无法设置。</para>
    /// <para>每个字段的值根据字段类型填写相应的字段。</para>
    /// <para>* 当`type`为"number"时，应使用`number_value`字段，表示数字类型自定义字段的值；</para>
    /// <para>* 当`type`为"member"时，应使用`member_value`字段，表示人员类型自定义字段的值；</para>
    /// <para>* 当`type`为"datetime"时，应使用`datetime_value`字段，表示日期类型自定义字段的值；</para>
    /// <para>* 当`type`为"single_select"时，应使用`single_select_value`字段，表示单选类型自定义字段的值；</para>
    /// <para>* 当`type`为"multi_select"时，应使用`multi_select_value`字段，表示多选类型自定义字段的值；</para>
    /// <para>* 当`type`为“text”时，应使用`text_value`字段，表示文本字段类型的值。</para>
    /// </summary>
    public record InputCustomFieldValue
    {
        /// <summary>
        /// <para>自定义字段guid</para>
        /// <para>必填：是</para>
        /// <para>示例值：73b21903-0041-4796-a11e-f8be919a7063</para>
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; } = string.Empty;

        /// <summary>
        /// <para>数字类型的自定义字段值，填写一个合法数字的字符串表示，空字符串表示设为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.23</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("number_value")]
        public string? NumberValue { get; set; }

        /// <summary>
        /// <para>人员类型的自定义字段值。可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当字段设为只不能多选时只能输入一个值。设为空数组表示设为空。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// </summary>
        [JsonProperty("member_value")]
        public Member[]? MemberValues { get; set; }

        /// <summary>
        /// <para>人员类型的自定义字段值。可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当字段设为只不能多选时只能输入一个值。设为空数组表示设为空。</para>
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
            /// <para>成员类型（默认user，可不填写）</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>日期类型自定义字段值，可以输入一个表示日期的以毫秒为单位的时间戳字符串。设为空字符串表示设为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1698192000000</para>
        /// </summary>
        [JsonProperty("datetime_value")]
        public string? DatetimeValue { get; set; }

        /// <summary>
        /// <para>单选类型字段值，填写一个字段选项的option_guid。设置为空字符串表示设为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：73b21903-0041-4796-a11e-f8be919a7063</para>
        /// <para>最大长度：100</para>
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
        /// <para>文本类型字段值。可以填写最多3000字符。使用空字符串表示设为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：这是一段文本描述。</para>
        /// </summary>
        [JsonProperty("text_value")]
        public string? TextValue { get; set; }
    }
}
