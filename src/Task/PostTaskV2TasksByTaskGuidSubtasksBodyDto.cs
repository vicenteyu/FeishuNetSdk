// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidSubtasksBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建子任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建子任务 请求体
/// <para>给一个任务创建一个子任务。</para>
/// <para>接口功能除了额外需要输入父任务的GUID之外，和[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create)接口功能完全一致。</para>
/// <para>接口ID：7255580838154551324</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task-subtask/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask-subtask%2fcreate</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidSubtasksBodyDto
{
    /// <summary>
    /// <para>任务标题</para>
    /// <para>必填：是</para>
    /// <para>示例值：针对全年销售进行一次复盘</para>
    /// <para>最大长度：10000</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务摘要</para>
    /// <para>必填：否</para>
    /// <para>示例值：需要事先阅读复盘总结文档</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>任务截止时间戳(ms)，截止时间戳和截止日期选择一个填写。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1675742789470</para>
    /// </summary>
    [JsonPropertyName("due")]
    public PostTaskV2TasksByTaskGuidSubtasksBodyDtoDue? Due { get; set; }

    /// <summary>
    /// <para>任务截止时间戳(ms)，截止时间戳和截止日期选择一个填写。</para>
    /// </summary>
    public record PostTaskV2TasksByTaskGuidSubtasksBodyDtoDue
    {
        /// <summary>
        /// <para>截止时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果截止时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675454764000</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// <para>是否截止到一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_all_day")]
        public bool? IsAllDay { get; set; }
    }

    /// <summary>
    /// <para>任务关联的第三方平台来源信息。详见[如何使用Origin?](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("origin")]
    public PostTaskV2TasksByTaskGuidSubtasksBodyDtoOrigin? Origin { get; set; }

    /// <summary>
    /// <para>任务关联的第三方平台来源信息。详见[如何使用Origin?](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)</para>
    /// </summary>
    public record PostTaskV2TasksByTaskGuidSubtasksBodyDtoOrigin
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
            /// <para>示例值：Tabledetravail</para>
            /// </summary>
            [JsonPropertyName("fr_fr")]
            public string? FrFr { get; set; }

            /// <summary>
            /// <para>意大利语</para>
            /// <para>必填：否</para>
            /// <para>示例值：bancodilavoro</para>
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
            /// <para>示例值：bancodetrabajo</para>
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
        public PostTaskV2TasksByTaskGuidSubtasksBodyDtoOriginHref? Href { get; set; }

        /// <summary>
        /// <para>任务关联的来源平台详情页链接</para>
        /// </summary>
        public record PostTaskV2TasksByTaskGuidSubtasksBodyDtoOriginHref
        {
            /// <summary>
            /// <para>链接对应的地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.example.com</para>
            /// <para>最大长度：1024</para>
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
    /// <para>调用者可以传入的任意附带到任务上的数据。在获取任务详情时会原样返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：dGVzdA==</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>任务的完成时刻时间戳(ms)</para>
    /// <para>必填：否</para>
    /// <para>示例值：1675742789470</para>
    /// <para>最大长度：20</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("completed_at")]
    public string? CompletedAt { get; set; }

    /// <summary>
    /// <para>任务成员列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[]? Members { get; set; }

    /// <summary>
    /// <para>任务成员列表</para>
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
        /// <para>成员角色，支持"assignee"或者"follower"</para>
        /// <para>必填：否</para>
        /// <para>示例值：assignee</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }
    }

    /// <summary>
    /// <para>如果设置，则该任务为“重复任务”。该字段表示了重复任务的重复规则。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“如何使用重复任务？”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonPropertyName("repeat_rule")]
    public string? RepeatRule { get; set; }

    /// <summary>
    /// <para>任务自定义完成规则。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“如何使用自定义完成？”章节。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_complete")]
    public PostTaskV2TasksByTaskGuidSubtasksBodyDtoCustomComplete? CustomComplete { get; set; }

    /// <summary>
    /// <para>任务自定义完成规则。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“如何使用自定义完成？”章节。</para>
    /// </summary>
    public record PostTaskV2TasksByTaskGuidSubtasksBodyDtoCustomComplete
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
                /// <para>示例值：Tabledetravail</para>
                /// </summary>
                [JsonPropertyName("fr_fr")]
                public string? FrFr { get; set; }

                /// <summary>
                /// <para>意大利语</para>
                /// <para>必填：否</para>
                /// <para>示例值：bancodilavoro</para>
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
                /// <para>示例值：bancodetrabajo</para>
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
        /// <para>飞书ios端的自定义完成配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ios")]
        public CustomCompleteItem? Ios { get; set; }

        /// <summary>
        /// <para>飞书android端的自定义完成配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("android")]
        public CustomCompleteItem? Android { get; set; }
    }

    /// <summary>
    /// <para>任务所在清单的信息。如果设置，则表示创建的任务要直接加入到指定清单。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tasklists")]
    public TaskInTasklistInfo[]? Tasklists { get; set; }

    /// <summary>
    /// <para>任务所在清单的信息。如果设置，则表示创建的任务要直接加入到指定清单。</para>
    /// </summary>
    public record TaskInTasklistInfo
    {
        /// <summary>
        /// <para>任务要加入的清单的GUID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("tasklist_guid")]
        public string? TasklistGuid { get; set; }

        /// <summary>
        /// <para>任务所在清单的自定义分组GUID。如果设置了清单GUID但没有设置自定义分组GUID，则自动加入该清单的默认分组。</para>
        /// <para>必填：否</para>
        /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
        /// </summary>
        [JsonPropertyName("section_guid")]
        public string? SectionGuid { get; set; }
    }

    /// <summary>
    /// <para>幂等token。如果提供则触发后端实现幂等行为。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 幂等调用 ”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：daa2237f-8310-4707-a83b-52c8a81e0fb7</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }

    /// <summary>
    /// <para>任务的开始时间(ms)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start")]
    public PostTaskV2TasksByTaskGuidSubtasksBodyDtoStart? Start { get; set; }

    /// <summary>
    /// <para>任务的开始时间(ms)</para>
    /// </summary>
    public record PostTaskV2TasksByTaskGuidSubtasksBodyDtoStart
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
    /// <para>任务提醒</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reminders")]
    public Reminder[]? Reminders { get; set; }

    /// <summary>
    /// <para>任务提醒</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>相对于截止时间的提醒时间分钟数。例如30表示截止时间前30分钟提醒；0表示截止时提醒。</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("relative_fire_minute")]
        public int RelativeFireMinute { get; set; }
    }
}
