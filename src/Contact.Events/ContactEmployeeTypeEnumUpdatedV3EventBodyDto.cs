// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ContactEmployeeTypeEnumUpdatedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改人员类型名称 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Events;
/// <summary>
/// 修改人员类型名称 事件体
/// <para>当应用订阅该事件后，若果更新了人员类型的选项内容（包括默认内容 content 参数和国际化内容 i18n_content），则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=contact&amp;version=v3&amp;resource=employee_type_enum&amp;event=updated)</para>
/// <para>接口ID：6985055606752591900</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fevents%2fupdated</para>
/// </summary>
public record ContactEmployeeTypeEnumUpdatedV3EventBodyDto() : EventBodyDto("contact.employee_type_enum.updated_v3")
{
    /// <summary>
    /// <para>更新前的人员类型信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("old_enum")]
    public EmployeeTypeEnum? OldEnum { get; set; }

    /// <summary>
    /// <para>更新后的人员类型信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("new_enum")]
    public EmployeeTypeEnum? NewEnum { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EmployeeTypeEnum
    {
        /// <summary>
        /// <para>人员类型的选项 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("enum_id")]
        public string? EnumId { get; set; }

        /// <summary>
        /// <para>人员类型的选项编号。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("enum_value")]
        public string? EnumValue { get; set; }

        /// <summary>
        /// <para>人员类型的选项内容。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `100` 字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>人员类型的选项类型。</para>
        /// <para>**可选值有**：</para>
        /// <para>1:内置类型,2:自定义</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：内置类型</item>
        /// <item>2：自定义</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("enum_type")]
        public int? EnumType { get; set; }

        /// <summary>
        /// <para>人员类型的选项激活状态。</para>
        /// <para>**可选值有**：</para>
        /// <para>1:激活,2:未激活</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：激活</item>
        /// <item>2：未激活</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("enum_status")]
        public int? EnumStatus { get; set; }

        /// <summary>
        /// <para>选项内容的国际化配置。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_content")]
        public I18nContentSuffix[]? I18nContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record I18nContentSuffix
        {
            /// <summary>
            /// <para>语言版本。例如：</para>
            /// <para>- zh_cn：中文</para>
            /// <para>- en_us：英文</para>
            /// <para>- ja_jp：日文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言版本对应的内容。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
