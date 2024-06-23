// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV2CustomFieldsByCustomFieldGuidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自定义字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取自定义字段 响应体
/// <para>根据一个自定义字段的GUID，获取其详细的设置信息。</para>
/// <para>接口ID：7270765454292238338</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fget</para>
/// </summary>
public record GetTaskV2CustomFieldsByCustomFieldGuidResponseDto
{
    /// <summary>
    /// <para>获取的自定义字段数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_field")]
    public GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomField? CustomField { get; set; }

    /// <summary>
    /// <para>获取的自定义字段数据</para>
    /// </summary>
    public record GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomField
    {
        /// <summary>
        /// <para>自定义字段的GUID</para>
        /// <para>必填：否</para>
        /// <para>示例值：34d4b29f-3d58-4bc5-b752-6be80fb687c8</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>自定义字段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：优先级</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>自定义字段类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：number</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>数字类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("number_setting")]
        public GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldNumberSetting? NumberSetting { get; set; }

        /// <summary>
        /// <para>数字类型的字段设置</para>
        /// </summary>
        public record GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldNumberSetting
        {
            /// <summary>
            /// <para>数字展示的格式</para>
            /// <para>必填：否</para>
            /// <para>示例值：normal</para>
            /// <para>可选值：<list type="bullet">
            /// <item>normal：常规数字格式</item>
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
            /// <para>自定义符号</para>
            /// <para>必填：否</para>
            /// <para>示例值：自定义符号</para>
            /// </summary>
            [JsonPropertyName("custom_symbol")]
            public string? CustomSymbol { get; set; }

            /// <summary>
            /// <para>自定义符号的显示位置。</para>
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
            /// <para>最大值：6</para>
            /// <para>最小值：0</para>
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
        public GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldMemberSetting? MemberSetting { get; set; }

        /// <summary>
        /// <para>人员类型的字段设置</para>
        /// </summary>
        public record GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldMemberSetting
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
        public GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldDatetimeSetting? DatetimeSetting { get; set; }

        /// <summary>
        /// <para>时间日期类型的字段设置</para>
        /// </summary>
        public record GetTaskV2CustomFieldsByCustomFieldGuidResponseDtoCustomFieldDatetimeSetting
        {
            /// <summary>
            /// <para>日期显示格式</para>
            /// <para>必填：否</para>
            /// <para>示例值：yyyy/mm/dd</para>
            /// </summary>
            [JsonPropertyName("format")]
            public string? Format { get; set; }
        }

        /// <summary>
        /// <para>单选类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("single_select_setting")]
        public SelectSetting? SingleSelectSetting { get; set; }

        /// <summary>
        /// <para>单选类型的字段设置</para>
        /// </summary>
        public record SelectSetting
        {
            /// <summary>
            /// <para>单选选项</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("options")]
            public Option[]? Options { get; set; }

            /// <summary>
            /// <para>单选选项</para>
            /// </summary>
            public record Option
            {
                /// <summary>
                /// <para>选项的GUID。</para>
                /// <para>必填：否</para>
                /// <para>示例值：4216f79b-3fda-4dc6-a0c4-a16022e47152</para>
                /// </summary>
                [JsonPropertyName("guid")]
                public string? Guid { get; set; }

                /// <summary>
                /// <para>选项名称，不能为空，最大50个字符</para>
                /// <para>必填：否</para>
                /// <para>示例值：高优</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>选项的颜色索引值，可以是0～54中的一个数字。如果不填写则会随机选一个。</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：54</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("color_index")]
                public int? ColorIndex { get; set; }

                /// <summary>
                /// <para>选项是否隐藏。隐藏后的选项在界面不可见，也不可以再通过openapi将字段值设为该选项。</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_hidden")]
                public bool? IsHidden { get; set; }
            }
        }

        /// <summary>
        /// <para>多选类型的字段设置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("multi_select_setting")]
        public SelectSetting? MultiSelectSetting { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>创建人</para>
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
            /// <para>示例值：creator</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>自定义字段创建的时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1688196600000</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>自定义字段的更新时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1688196600000</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>文本字段配置（目前文本类型没有可设置项）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("text_setting")]
        public object? TextSetting { get; set; }
    }
}
