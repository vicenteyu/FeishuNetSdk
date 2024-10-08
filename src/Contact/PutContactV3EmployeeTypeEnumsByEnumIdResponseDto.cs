// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutContactV3EmployeeTypeEnumsByEnumIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人员类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新人员类型 响应体
/// <para>调用该接口更新指定的自定义人员类型信息。</para>
/// <para>## 注意事项</para>
/// <para>仅支持更新自定义的人员类型。默认包含的正式、实习、外包、劳务、顾问五个选项不支持更新。</para>
/// <para>接口ID：6985055606752460828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fupdate</para>
/// </summary>
public record PutContactV3EmployeeTypeEnumsByEnumIdResponseDto
{
    /// <summary>
    /// <para>更新后的人员类型字段信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_type_enum")]
    public PutContactV3EmployeeTypeEnumsByEnumIdResponseDtoEmployeeTypeEnum? EmployeeTypeEnum { get; set; }

    /// <summary>
    /// <para>更新后的人员类型字段信息。</para>
    /// </summary>
    public record PutContactV3EmployeeTypeEnumsByEnumIdResponseDtoEmployeeTypeEnum
    {
        /// <summary>
        /// <para>人员类型的选项 ID。后续可以使用该 ID 更新、删除选项。</para>
        /// <para>必填：否</para>
        /// <para>示例值：exGeIjow7zIqWMy+ONkFxA==</para>
        /// </summary>
        [JsonPropertyName("enum_id")]
        public string? EnumId { get; set; }

        /// <summary>
        /// <para>选项的编号值，由系统生成的编号。后续可使用该编号配置用户的人员类型属性。例如，调用[创建用户](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/create)接口时，employee_type 参数值对应的就是当前的 enum_value。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("enum_value")]
        public string? EnumValue { get; set; }

        /// <summary>
        /// <para>选项内容。</para>
        /// <para>必填：是</para>
        /// <para>示例值：专家</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>选项类型。</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：内置类型</item>
        /// <item>2：自定义</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("enum_type")]
        public int EnumType { get; set; }

        /// <summary>
        /// <para>选项的激活状态。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：激活</item>
        /// <item>2：未激活</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("enum_status")]
        public int EnumStatus { get; set; }

        /// <summary>
        /// <para>选项内容的国际化配置。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_content")]
        public I18nContent[]? I18nContents { get; set; }

        /// <summary>
        /// <para>选项内容的国际化配置。</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本。例如：</para>
            /// <para>- zh_cn：中文</para>
            /// <para>- en_us：英文</para>
            /// <para>- ja_jp：日文</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言版本对应的内容。</para>
            /// <para>必填：否</para>
            /// <para>示例值：专家（中文）</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
