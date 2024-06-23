// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchTaskV2CustomFieldsByCustomFieldGuidBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新自定义字段 请求体
/// <para>更新一个自定义字段的名称和设定。更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`custom_field`字段中填写要修改的字段的新值即可。自定义字段不允许修改类型，只能根据类型修改其设置。</para>
/// <para>`update_fields`支持更新的字段包括：</para>
/// <para>* `name`：自定义字段名称</para>
/// <para>* `number_setting` ：数字类型设置（当且仅当要更新的自定义字段类型是数字时)</para>
/// <para>* `member_setting` ：人员类型设置（当且仅当要更新的自定义字段类型是人员时)</para>
/// <para>* `datetime_setting` ：日期类型设置 (当且仅当要更新的自定义字段类型是日期时)</para>
/// <para>* `single_select_setting`：单选类型设置 (当且仅当要更新的自定义字段类型是单选时)</para>
/// <para>* `multi_select_setting`：多选类型设置 (当且仅当要更新的自定义字段类型是多选时)</para>
/// <para>* `text_setting`: 文本类型设置（目前文本类型没有可设置项）</para>
/// <para>当更改某个设置时，如果不填写一个字段，表示不覆盖原有的设定。比如，对于一个数字，原有的setting是:</para>
/// <para>```json</para>
/// <para>"number_setting": {</para>
/// <para>"format": "normal",</para>
/// <para>"decimal_count": 2,</para>
/// <para>"separator": "none",</para>
/// <para>"custom_symbol": "L",</para>
/// <para>"custom_symbol_position": "right"</para>
/// <para>}</para>
/// <para>```</para>
/// <para>使用如下参数调用接口：</para>
/// <para>```</para>
/// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
/// <para>{</para>
/// <para>"custom_field": {</para>
/// <para>"number_setting": {</para>
/// <para>"decimal_count": 4</para>
/// <para>}</para>
/// <para>},</para>
/// <para>"update_fields": ["number_setting"]</para>
/// <para>}</para>
/// <para>```</para>
/// <para>表示仅仅将小数位数从2改为4，其余的设置`format`, `separator`, `custom_field`等都不变。</para>
/// <para>对于单选/多选类型的自定义字段，其设定是一个选项列表。更新时，使用方式接近使用App的界面。使用者不必传入字段的所有选项，而是只需要提供最终希望界面可见（is_hidden=false) 的选项。原有字段中的选项如果没有出现在输入中，则被置为`is_hidden=true`并放到所有可见选项之后。</para>
/// <para>对于某一个更新的选项，如果提供了option_guid，将视作更新该选项（此时option_guid必须存在于当前字段，否则会返回错误）；如果不提供，将视作新建一个选项（新的选项的option_guid会在reponse中被返回)。</para>
/// <para>例如，一个单选字段原来有3个选项A，B，C，D。其中C是隐藏的。用户可以这样更新选项：</para>
/// <para>```</para>
/// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
/// <para>{</para>
/// <para>"custom_field": {</para>
/// <para>"single_select_setting": {</para>
/// <para>"optoins": [</para>
/// <para>{</para>
/// <para>"name": "E",</para>
/// <para>"color_index": 25</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"guid": "&lt;option_guid of A&gt;"</para>
/// <para>"name": "A2"</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"guid": "&lt;option_guid of C&gt;",</para>
/// <para>},</para>
/// <para>]</para>
/// <para>}</para>
/// <para>},</para>
/// <para>"update_fields": ["single_select_setting"]</para>
/// <para>}</para>
/// <para>```</para>
/// <para>调用后最终得到了新的选项列表E, A, C, B, D。其中：</para>
/// <para>* 选项E被新建出来，其`color_index`被设为了25。</para>
/// <para>* 选项A被更新，其名称被改为了"A2"。但其color_index因为没有设置而保持不变；</para>
/// <para>* 选项整体顺序遵循用户的输入顺序，即E，A，C。同时E，A，C作为直接的输入，其is_hidden均被设为了false，其中，C原本是is_hidden=true，也会被设置为is_hidden=false。</para>
/// <para>* 选项B和D因为用户没有输入，其`is_hidden`被置为了true，并且被放到了所有用户输入的选项之后。</para>
/// <para>如果只是单纯的希望修改用户可见的选项的顺序，比如从原本的选项A,B,C修改为C,B,A，可以这样调用接口：</para>
/// <para>```</para>
/// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
/// <para>{</para>
/// <para>"custom_field": {</para>
/// <para>"single_select_setting": {</para>
/// <para>"optoins": [</para>
/// <para>{</para>
/// <para>"guid": "&lt;option_guid_of_C&gt;"</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"guid": "&lt;option_guid of B&gt;"</para>
/// <para>},</para>
/// <para>{</para>
/// <para>"guid": "&lt;option_guid of A&gt;",</para>
/// <para>},</para>
/// <para>]</para>
/// <para>}</para>
/// <para>},</para>
/// <para>"update_fields": ["single_select_setting"]</para>
/// <para>}</para>
/// <para>```</para>
/// <para>如果希望直接将字段里的所有选项都标记为不可见，可以这样调用接口：</para>
/// <para>```</para>
/// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
/// <para>{</para>
/// <para>"custom_field": {</para>
/// <para>"single_select_setting": {</para>
/// <para>"optoins": []</para>
/// <para>}</para>
/// <para>},</para>
/// <para>"update_fields": ["single_select_setting"]</para>
/// <para>}</para>
/// <para>```</para>
/// <para>更新单选/多选字段的选项必须满足“可见选项名字不能重复”的约束。否则会返回错误。开发者需要自行保证输入的选项名不可以重复。</para>
/// <para>如希望只更新单个选项，或者希望单独设置某个选项的is_hidden，本接口无法支持，但可以使用[更新自定义字段选项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/patch)接口实现。</para>
/// <para>接口ID：7270765454292254722</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fpatch</para>
/// </summary>
public record PatchTaskV2CustomFieldsByCustomFieldGuidBodyDto
{
    /// <summary>
    /// <para>要修改的自定义字段数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_field")]
    public InputCustomField? CustomField { get; set; }

    /// <summary>
    /// <para>要修改的自定义字段数据</para>
    /// </summary>
    public record InputCustomField
    {
        /// <summary>
        /// <para>字段名称，支持最大50个字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：优先级</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>数字类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("number_setting")]
        public InputCustomFieldNumberSetting? NumberSetting { get; set; }

        /// <summary>
        /// <para>数字类型的字段设置</para>
        /// </summary>
        public record InputCustomFieldNumberSetting
        {
            /// <summary>
            /// <para>数字展示的格式</para>
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
            [JsonPropertyName("format")]
            public string? Format { get; set; }

            /// <summary>
            /// <para>自定义符号，支持最大4个字符。只有`format`设为"custom"时才会生效。</para>
            /// <para>必填：否</para>
            /// <para>示例值：€</para>
            /// </summary>
            [JsonPropertyName("custom_symbol")]
            public string? CustomSymbol { get; set; }

            /// <summary>
            /// <para>自定义符号显示的位置。</para>
            /// <para>必填：否</para>
            /// <para>示例值：left</para>
            /// <para>可选值：<list type="bullet">
            /// <item>left：自定义符号放在数字左边</item>
            /// <item>right：自定义符号放在数字右边</item>
            /// </list></para>
            /// <para>默认值：right</para>
            /// </summary>
            [JsonPropertyName("custom_symbol_position")]
            public string? CustomSymbolPosition { get; set; }

            /// <summary>
            /// <para>分隔符样式</para>
            /// <para>必填：否</para>
            /// <para>示例值：thousand</para>
            /// <para>可选值：<list type="bullet">
            /// <item>none：无分隔符</item>
            /// <item>thousand：千分位分隔符</item>
            /// </list></para>
            /// <para>默认值：none</para>
            /// </summary>
            [JsonPropertyName("separator")]
            public string? Separator { get; set; }

            /// <summary>
            /// <para>保留小数位数。输入的数字值的小数位数如果比该设置多，多余的位数将被四舍五入后舍弃。如果`format`为"percentage"，表示变为百分数之后的小数位数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>默认值：0</para>
            /// </summary>
            [JsonPropertyName("decimal_count")]
            public int? DecimalCount { get; set; }
        }

        /// <summary>
        /// <para>人员类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("member_setting")]
        public InputCustomFieldMemberSetting? MemberSetting { get; set; }

        /// <summary>
        /// <para>人员类型的字段设置</para>
        /// </summary>
        public record InputCustomFieldMemberSetting
        {
            /// <summary>
            /// <para>是否支持多选</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("multi")]
            public bool? Multi { get; set; }
        }

        /// <summary>
        /// <para>时间日期类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("datetime_setting")]
        public InputCustomFieldDatetimeSetting? DatetimeSetting { get; set; }

        /// <summary>
        /// <para>时间日期类型的字段设置</para>
        /// </summary>
        public record InputCustomFieldDatetimeSetting
        {
            /// <summary>
            /// <para>日期显示格式。支持</para>
            /// <para>&lt;md-enum&gt;</para>
            /// <para>&lt;md-enum-item key="yyyy-mm-dd"&gt;以短横分隔的年月日，例如2023-08-24&lt;/md-enum-item&gt;</para>
            /// <para>&lt;md-enum-item key="yyyy/mm/dd"&gt;以斜杠分隔的年月日，例如2023/08/04&lt;/md-enum-item&gt;</para>
            /// <para>&lt;md-enum-item key="mm/dd/yyyy"&gt;以斜杠分隔的月日年，例如08/24/2023&lt;/md-enum-item&gt;</para>
            /// <para>&lt;md-enum-item key="dd/mm/yyyy"&gt;以斜杠分隔的日月年，例如24/08/2023&lt;/md-enum-item&gt;</para>
            /// <para>&lt;/md-enum&gt;</para>
            /// <para>必填：否</para>
            /// <para>示例值：yyyy/mm/dd</para>
            /// </summary>
            [JsonPropertyName("format")]
            public string? Format { get; set; }
        }

        /// <summary>
        /// <para>单选设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("single_select_setting")]
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
            [JsonPropertyName("options")]
            public Option[]? Options { get; set; }

            /// <summary>
            /// <para>单选选项</para>
            /// </summary>
            public record Option
            {
                /// <summary>
                /// <para>选项的GUID。如果填写表示更新；不填写表示新建。</para>
                /// <para>必填：否</para>
                /// <para>示例值：4216f79b-3fda-4dc6-a0c4-a16022e47152</para>
                /// </summary>
                [JsonPropertyName("guid")]
                public string? Guid { get; set; }

                /// <summary>
                /// <para>选项名称，最大50个字符</para>
                /// <para>必填：否</para>
                /// <para>示例值：高优</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>选项的颜色索引值，可以是0～54中的一个数字。</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("color_index")]
                public int? ColorIndex { get; set; }
            }
        }

        /// <summary>
        /// <para>多选设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("multi_select_setting")]
        public SelectSetting? MultiSelectSetting { get; set; }

        /// <summary>
        /// <para>文本类型设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("text_setting")]
        public object? TextSetting { get; set; }
    }

    /// <summary>
    /// <para>要修改的自定义字段类型，支持：</para>
    /// <para>* `name`：自定义字段名称。</para>
    /// <para>* `number_setting` ：数字类型设置（当且仅当要更新的自定义字段类型是数字时)</para>
    /// <para>* `member_setting` ：人员类型设置（当且仅当要更新的自定义字段类型是人员时)</para>
    /// <para>* `datetime_setting` ：日期类型设置 (当且仅当要更新的自定义字段类型是日期时)</para>
    /// <para>* `single_select_setting`：单选类型设置 (当且仅当要更新的自定义字段类型是单选时)</para>
    /// <para>* `multi_select_setting`：多选类型设置 (当且仅当要更新的自定义字段类型是多选时)</para>
    /// <para>* `text_setting`: 文本类型设置（当前无可设置项）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[]? UpdateFields { get; set; }
}
