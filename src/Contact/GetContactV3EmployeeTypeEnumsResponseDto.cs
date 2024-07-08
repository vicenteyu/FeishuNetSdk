// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3EmployeeTypeEnumsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人员类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询人员类型 响应体
/// <para>调用该接口查询当前租户下所有的人员类型信息，包括选项 ID、类型、编号以及内容等。</para>
/// <para>接口ID：6985055606752559132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2flist</para>
/// </summary>
public record GetContactV3EmployeeTypeEnumsResponseDto
{
    /// <summary>
    /// <para>人员类型的选项信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public EmployeeTypeEnum[]? Items { get; set; }

    /// <summary>
    /// <para>人员类型的选项信息。</para>
    /// </summary>
    public record EmployeeTypeEnum
    {
        /// <summary>
        /// <para>选项 ID。后续可以使用该 ID 更新、删除选项。</para>
        /// <para>必填：否</para>
        /// <para>示例值：exGeIjow7zIqWMy+ONkFxA==</para>
        /// </summary>
        [JsonPropertyName("enum_id")]
        public string? EnumId { get; set; }

        /// <summary>
        /// <para>选项的编号值。后续可使用该编号配置用户的人员类型属性。例如，调用[创建用户](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/create)接口时，employee_type 参数值对应的就是当前的 enum_value。</para>
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

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
