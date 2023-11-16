namespace FeishuNetSdk.Task;
/// <summary>
/// 更新任务 请求体
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
/// <para>* `repeat_rule` - 重复任务规则。</para>
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
public record PatchTaskV2TasksByTaskGuidBodyDto
{
    /// <summary>
    /// <para>要更新的任务数据，只需要设置出现在`update_fields`中的字段即可。如果`update_fields`设置了要变更一个字段名，但是`task`里没设置新的值，则表示将该字段清空。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task")]
    public InputTask? Task { get; set; }

    /// <summary>
    /// <para>要更新的任务数据，只需要设置出现在`update_fields`中的字段即可。如果`update_fields`设置了要变更一个字段名，但是`task`里没设置新的值，则表示将该字段清空。</para>
    /// </summary>
    public record InputTask
    {
        /// <summary>
        /// <para>任务标题。如更新标题，不可将任务标题设为空。标题最大支持3000个utf8 字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：针对全年销售进行一次复盘</para>
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>任务描述。描述最大支持3000个utf8字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：需要事先阅读复盘总结文档</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>任务截止时间。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("due")]
        public InputTaskDue? Due { get; set; }

        /// <summary>
        /// <para>任务截止时间。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
        /// </summary>
        public record InputTaskDue
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
        /// <para>如果设置，则该任务为“重复任务”。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“如何使用重复任务？”章节。</para>
        /// <para>必填：否</para>
        /// <para>示例值：FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("repeat_rule")]
        public string? RepeatRule { get; set; }

        /// <summary>
        /// <para>任务自定义完成配置。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“ 如何使用任务自定义完成？”章节。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_complete")]
        public InputTaskCustomComplete? CustomComplete { get; set; }

        /// <summary>
        /// <para>任务自定义完成配置。详见[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)中的“ 如何使用任务自定义完成？”章节。</para>
        /// </summary>
        public record InputTaskCustomComplete
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
        /// <para>任务的开始时间(ms)。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start")]
        public InputTaskStart? Start { get; set; }

        /// <summary>
        /// <para>任务的开始时间(ms)。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
        /// </summary>
        public record InputTaskStart
        {
            /// <summary>
            /// <para>开始时间的时间戳，距1970-01-01 00:00:00的毫秒数。如果开始时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
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
        /// <para>任务的完成模式。1 - 会签任务；2 - 或签任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>是否是里程碑任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_milestone")]
        public bool? IsMilestone { get; set; }

        /// <summary>
        /// <para>自定义字段值。</para>
        /// <para>如要更新，每个字段的值根据字段类型填写相应的字段。</para>
        /// <para>* 当`type`为"number"时，应使用`number_value`字段，表示数字类型自定义字段的值；</para>
        /// <para>* 当`type`为"member"时，应使用`member_value`字段，表示人员类型自定义字段的值；</para>
        /// <para>* 当`type`为"datetime"时，应使用`datetime_value`字段，表示日期类型自定义字段的值；</para>
        /// <para>* 当`type`为"single_select"时，应使用`single_select_value`字段，表示单选类型自定义字段的值；</para>
        /// <para>* 当`type`为"multi_select"时，应使用`multi_select_value`字段，表示多选类型自定义字段的值；</para>
        /// <para>* 当`type`为"text"时，应使用`text_value`字段，表示文本类型自定义字段的值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public InputCustomFieldValue[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段值。</para>
        /// <para>如要更新，每个字段的值根据字段类型填写相应的字段。</para>
        /// <para>* 当`type`为"number"时，应使用`number_value`字段，表示数字类型自定义字段的值；</para>
        /// <para>* 当`type`为"member"时，应使用`member_value`字段，表示人员类型自定义字段的值；</para>
        /// <para>* 当`type`为"datetime"时，应使用`datetime_value`字段，表示日期类型自定义字段的值；</para>
        /// <para>* 当`type`为"single_select"时，应使用`single_select_value`字段，表示单选类型自定义字段的值；</para>
        /// <para>* 当`type`为"multi_select"时，应使用`multi_select_value`字段，表示多选类型自定义字段的值；</para>
        /// <para>* 当`type`为"text"时，应使用`text_value`字段，表示文本类型自定义字段的值。</para>
        /// </summary>
        public record InputCustomFieldValue
        {
            /// <summary>
            /// <para>自定义字段guid</para>
            /// <para>必填：是</para>
            /// <para>示例值：73b21903-0041-4796-a11e-f8be919a7063</para>
            /// </summary>
            [JsonPropertyName("guid")]
            public string Guid { get; set; } = string.Empty;

            /// <summary>
            /// <para>数字类型的自定义字段值，填写一个合法数字的字符串表示，空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.23</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("number_value")]
            public string? NumberValue { get; set; }

            /// <summary>
            /// <para>人员类型的自定义字段值。可以设置1个或多个用户的id（遵循member格式，只支持user类型）。当字段设为只不能多选时只能输入一个值。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonPropertyName("member_value")]
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
            }

            /// <summary>
            /// <para>日期类型自定义字段值，可以输入一个表示日期的以毫秒为单位的字符串。设为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1698192000000</para>
            /// </summary>
            [JsonPropertyName("datetime_value")]
            public string? DatetimeValue { get; set; }

            /// <summary>
            /// <para>单选类型字段值，填写一个字段选项的option_guid。设置为空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：73b21903-0041-4796-a11e-f8be919a7063</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("single_select_value")]
            public string? SingleSelectValue { get; set; }

            /// <summary>
            /// <para>多选类型字段值，可以填写一个或多个本字段的option_guid。设为空数组表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// </summary>
            [JsonPropertyName("multi_select_value")]
            public string[]? MultiSelectValue { get; set; }

            /// <summary>
            /// <para>文本类型字段值。可以填写最多3000字符。使用空字符串表示设为空。</para>
            /// <para>必填：否</para>
            /// <para>示例值：文本类型字段值。可以输入一段文本。空字符串表示清空。</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public string? TextValue { get; set; }
        }
    }

    /// <summary>
    /// <para>设置需要修改的字段</para>
    /// <para>&lt;md-enum&gt;</para>
    /// <para>&lt;md-enum-item key="summary" &gt;任务标题&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="description" &gt;任务描&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="start" &gt;任务开始时间&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="due" &gt;任务截止时间&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="completed_at" &gt;任务完成时间&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="extra" &gt;任务附属自定义数据&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="custom_complete" &gt;任务自定义完成规则&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="repeat_rule" &gt;任务重复规则&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="mode" &gt;任务完成模式&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key="is_milestone" &gt;是否是里程碑任务</para>
    /// <para>&lt;/md-enum-item&gt;</para>
    /// <para>&lt;md-enum-item key=custom_fields" &gt;自定义字段值</para>
    /// <para>&lt;/md-enum-item&gt;</para>
    /// <para>&lt;/md-enum&gt;</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[] UpdateFields { get; set; } = Array.Empty<string>();
}
