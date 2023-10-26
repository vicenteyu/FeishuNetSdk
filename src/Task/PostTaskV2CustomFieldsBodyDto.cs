using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建自定义字段 请求体
/// <para>创建一个自定义字段，并将其加入一个资源上（目前资源只支持清单）。创建自定义字段必须提供字段名称，类型和相应类型的设置。</para>
/// <para>目前任务自定义字段支持数字(number)，成员(member)，日期(datetime)，单选(single_select),多选(multi_select), 文本(text)几种类型。分别使用"number_setting", "member_setting", "datetime_setting", "single_select_setting", "multi_select_setting","text_setting"来设置。</para>
/// <para>例如创建一个数字类型的自定义字段，并添加到guid为"ec5ed63d-a4a9-44de-a935-7ba243471c0a"的清单，可以这样发请求。</para>
/// <para>```</para>
/// <para>POST /task/v2/custom_fields</para>
/// <para>{</para>
/// <para>"name": "价格",</para>
/// <para>"type": "number",</para>
/// <para>"resource_type": "tasklist",</para>
/// <para>"resource_id": "ec5ed63d-a4a9-44de-a935-7ba243471c0a",</para>
/// <para>"number_setting": {</para>
/// <para>"format": "cny",</para>
/// <para>"decimal_count": 2,</para>
/// <para>"separator": "thousand"</para>
/// <para>}</para>
/// <para>}</para>
/// <para>```</para>
/// <para>表示创建一个叫做“价格”的自定义字段，保留两位小数。在界面上显示时采用人民币的格式，并显示千分位分割符。</para>
/// <para>类似的，创建一个单选字段，可以这样调用接口：</para>
/// <para>```</para>
/// <para>POST /task/v2/custom_fields</para>
/// <para>{</para>
/// <para>"name": "优先级",</para>
/// <para>"type": "single_select",</para>
/// <para>"resource_type": "tasklist",</para>
/// <para>"resource_id": "ec5ed63d-a4a9-44de-a935-7ba243471c0a",</para>
/// <para>"single_select_setting": {</para>
/// <para>"options": [</para>
/// <para>{</para>
/// <para>"name": "高",</para>
/// <para>"color_index": 1</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"name": "中",</para>
/// <para>"color_index": 11</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"name": "低",</para>
/// <para>"color_index": 16</para>
/// <para>}</para>
/// <para>]</para>
/// <para>}</para>
/// <para>}</para>
/// <para>```</para>
/// <para>表示创建一个叫“优先级”的单选，包含“高”，“中”，“低”三个选项，每个选项设置一个颜色值。</para>
/// <para>接口ID：7270765454292320258</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fcreate</para>
/// </summary>
public record PostTaskV2CustomFieldsBodyDto
{
    /// <summary>
    /// <para>自定义字段要归属的资源类型，支持"tasklist"</para>
    /// <para>必填：是</para>
    /// <para>示例值：tasklist</para>
    /// <para>默认值：tasklist</para>
    /// </summary>
    [JsonProperty("resource_type")]
    public string ResourceType { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段要归属的资源ID，当`resource_type`为"tasklist"时必须填写清单的GUID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ec5ed63d-a4a9-44de-a935-7ba243471c0a</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("resource_id")]
    public string ResourceId { get; set; } = string.Empty;

    /// <summary>
    /// <para>字段名称，最大50个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：优先级</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段类型。</para>
    /// <para>必填：是</para>
    /// <para>示例值：number</para>
    /// <para>可选值：<list type="bullet">
    /// <item>number：数字</item>
    /// <item>datetime：日期</item>
    /// <item>member：成员</item>
    /// <item>single_select：单选</item>
    /// <item>multi_select：多选</item>
    /// <item>text：文本</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>数字类型的字段设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("number_setting")]
    public PostTaskV2CustomFieldsBodyDtoNumberSetting? NumberSetting { get; set; }

    /// <summary>
    /// <para>数字类型的字段设置</para>
    /// </summary>
    public record PostTaskV2CustomFieldsBodyDtoNumberSetting
    {
        /// <summary>
        /// <para>数字类型的自定义字段的值在App展示的格式。</para>
        /// <para>注意本设置仅影响App中的数字类型字段的字段值的显示格式，并不会影响openapi中输入/输出的字段值的格式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：normal</para>
        /// <para>可选值：<list type="bullet">
        /// <item>normal：常规数字</item>
        /// <item>percentage：百分比格式</item>
        /// <item>cny：人民币格式</item>
        /// <item>usd：美元格式</item>
        /// <item>custom：自定义符号</item>
        /// </list></para>
        /// <para>默认值：normal</para>
        /// </summary>
        [JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// <para>当`format`设为"custom"时，设置具体的自定义符号。</para>
        /// <para>注意本设置仅影响App中的数字类型字段的字段值的显示格式，并不会影响openapi输入/输出的字段值的格式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：自定义符号</para>
        /// </summary>
        [JsonProperty("custom_symbol")]
        public string? CustomSymbol { get; set; }

        /// <summary>
        /// <para>当`format`设为"custom"时，自定义符号相对于数字的显示位置。</para>
        /// <para>注意本设置仅影响App中的数字类型字段的字段值的显示格式，并不会影响openapi输入/输出的字段值的格式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：left</para>
        /// <para>可选值：<list type="bullet">
        /// <item>left：自定义符号显示在数字左边</item>
        /// <item>right：自定义符号显示在数字右边</item>
        /// </list></para>
        /// <para>默认值：right</para>
        /// </summary>
        [JsonProperty("custom_symbol_position")]
        public string? CustomSymbolPosition { get; set; }

        /// <summary>
        /// <para>数字类型自定义字段整数部分的分隔符样式。</para>
        /// <para>注意本设置仅影响App中的数字类型字段的字段值的显示格式，并不会影响openapi输入/输出的字段值的格式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：thousand</para>
        /// <para>可选值：<list type="bullet">
        /// <item>none：无分隔符</item>
        /// <item>thousand：千分位分隔符</item>
        /// </list></para>
        /// <para>默认值：none</para>
        /// </summary>
        [JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// <para>数字类型自定义字段的值保留的小数位数。多余的位数将被四舍五入。</para>
        /// <para>默认为0。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonProperty("decimal_count")]
        public int? DecimalCount { get; set; }
    }

    /// <summary>
    /// <para>人员类型的字段设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("member_setting")]
    public PostTaskV2CustomFieldsBodyDtoMemberSetting? MemberSetting { get; set; }

    /// <summary>
    /// <para>人员类型的字段设置</para>
    /// </summary>
    public record PostTaskV2CustomFieldsBodyDtoMemberSetting
    {
        /// <summary>
        /// <para>是否支持多选。</para>
        /// <para>默认为false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonProperty("multi")]
        public bool? Multi { get; set; }
    }

    /// <summary>
    /// <para>时间日期类型的字段设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("datetime_setting")]
    public PostTaskV2CustomFieldsBodyDtoDatetimeSetting? DatetimeSetting { get; set; }

    /// <summary>
    /// <para>时间日期类型的字段设置</para>
    /// </summary>
    public record PostTaskV2CustomFieldsBodyDtoDatetimeSetting
    {
        /// <summary>
        /// <para>日期时间格式，支持</para>
        /// <para>&lt;md-enum&gt;</para>
        /// <para>&lt;md-enum-item key="yyyy-mm-dd" &gt;以短横分隔的年月日，例如2023-08-24&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="yyyy/mm/dd" &gt;以斜杠分隔的年月日，例如2023/08/04&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="mm/dd/yyyy" &gt;以斜杠分隔的月日年，例如08/24/2023&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="dd/mm/yyyy" &gt;以斜杠分隔的日月年，例如24/08/2023&lt;/md-enum-item&gt;</para>
        /// <para>&lt;/md-enum&gt;</para>
        /// <para>默认为"yyyy-mm-dd"。</para>
        /// <para>注意本设置仅影响App中的时间日期类型字段的字段值的显示格式，并不会影响openapi输入/输出的字段值的格式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：yyyy/mm/dd</para>
        /// </summary>
        [JsonProperty("format")]
        public string? Format { get; set; }
    }

    /// <summary>
    /// <para>单选设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("single_select_setting")]
    public SelectSetting? SingleSelectSetting { get; set; }

    /// <summary>
    /// <para>单选设置</para>
    /// </summary>
    public record SelectSetting
    {
        /// <summary>
        /// <para>单选选项</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("options")]
        public Option[]? Options { get; set; }

        /// <summary>
        /// <para>单选选项</para>
        /// </summary>
        public record Option
        {
            /// <summary>
            /// <para>选项名称，不能为空，最大50个字符</para>
            /// <para>必填：是</para>
            /// <para>示例值：高优</para>
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>选项的颜色索引值，取值0～54。如不填写会自动从未使用的颜色索引值中随机选一个。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonProperty("color_index")]
            public int? ColorIndex { get; set; }

            /// <summary>
            /// <para>选项是否隐藏。隐藏后的选项在界面不可见，也不可以再通过openapi将字段值设为该选项。</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_hidden")]
            public bool? IsHidden { get; set; }
        }
    }

    /// <summary>
    /// <para>多选设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("multi_select_setting")]
    public SelectSetting? MultiSelectSetting { get; set; }

    /// <summary>
    /// <para>文本类型设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("text_setting")]
    public object? TextSetting { get; set; }
}
