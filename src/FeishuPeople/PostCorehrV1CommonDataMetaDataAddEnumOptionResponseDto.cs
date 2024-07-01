// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-01
//
// Last Modified By : yxr
// Last Modified On : 2024-07-01
// ************************************************************************
// <copyright file="PostCorehrV1CommonDataMetaDataAddEnumOptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加字段枚举值选项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 增加字段枚举值选项 响应体
/// <para>对于当前已有的所有自定义枚举字段，以及部分系统预置枚举字段，通过本接口可在字段中批量新增可选项</para>
/// <para>接口ID：7385867895124344836</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-meta_data/add_enum_option</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-meta_data%2fadd_enum_option</para>
/// </summary>
public record PostCorehrV1CommonDataMetaDataAddEnumOptionResponseDto
{
    /// <summary>
    /// <para>枚举字段 API name</para>
    /// <para>必填：否</para>
    /// <para>示例值：final_assessment_grade</para>
    /// </summary>
    [JsonPropertyName("enum_field_api_name")]
    public string? EnumFieldApiName { get; set; }

    /// <summary>
    /// <para>枚举全部选项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("enum_field_options")]
    public EnumFieldOption[]? EnumFieldOptions { get; set; }

    /// <summary>
    /// <para>枚举全部选项列表</para>
    /// </summary>
    public record EnumFieldOption
    {
        /// <summary>
        /// <para>枚举值选项 API Name，即选项的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：grade_e</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("option_api_name")]
        public string OptionApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>选项名称（需填写至少一个语种）</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public EnumFieldOptionName Name { get; set; } = new();

        /// <summary>
        /// <para>选项名称（需填写至少一个语种）</para>
        /// </summary>
        public record EnumFieldOptionName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }
    }
}
