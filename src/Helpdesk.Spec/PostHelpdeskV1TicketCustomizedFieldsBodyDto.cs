// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PostHelpdeskV1TicketCustomizedFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建工单自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk.Spec;
/// <summary>
/// 创建工单自定义字段 请求体
/// <para>该接口用于创建自定义字段。</para>
/// <para>接口ID：6955768699895562242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/create-ticket-customized-field</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2fcreate-ticket-customized-field</para>
/// </summary>
public record PostHelpdeskV1TicketCustomizedFieldsBodyDto
{
    /// <summary>
    /// <para>服务台ID（需要和请求 Header 中的服务台 ID 保持一致，可以省略）。</para>
    /// <para>**示例值**："1542164574896126"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("helpdesk_id")]
    public string? HelpdeskId { get; set; }

    /// <summary>
    /// <para>键名</para>
    /// <para>**示例值**："test dropdown"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("key_name")]
    public string KeyName { get; set; } = string.Empty;

    /// <summary>
    /// <para>名称</para>
    /// <para>**示例值**："test dropdown"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = string.Empty;

    /// <summary>
    /// <para>字段在列表后台管理列表中的位置</para>
    /// <para>**示例值**："3"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("position")]
    public string Position { get; set; } = string.Empty;

    /// <summary>
    /// <para>类型</para>
    /// <para>string - 单行文本</para>
    /// <para>multiline - 多行文本</para>
    /// <para>dropdown - 下拉列表</para>
    /// <para>dropdown_nested - 级联下拉</para>
    /// <para>**示例值**："dropdown"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("field_type")]
    public string FieldType { get; set; } = string.Empty;

    /// <summary>
    /// <para>描述</para>
    /// <para>**示例值**："下拉示例"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否可见</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }

    /// <summary>
    /// <para>是否必填</para>
    /// <para>**示例值**：false</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("required")]
    public bool Required { get; set; }

    /// <summary>
    /// <para>下拉列表选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dropdown_options")]
    public DropdownOptionSuffix? DropdownOptions { get; set; }

    /// <summary></summary>
    public record DropdownOptionSuffix
    {
        /// <summary>
        /// <para>选项列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("children")]
        public DropdownOption[]? Children { get; set; }

        /// <summary></summary>
        public record DropdownOption
        {
            /// <summary>
            /// <para>选项ID</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("tag")]
            public string Tag { get; set; } = string.Empty;

            /// <summary>
            /// <para>展示名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string DisplayName { get; set; } = string.Empty;

            /// <summary>
            /// <para>同上：选项列表，只适用于多层下拉列表（最多可以设置三级下拉列表）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("children")]
            public DropdownOption[]? Children { get; set; }
        }
    }

    /// <summary>
    /// <para>是否支持多选，仅在字段类型是dropdown的时候有效</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dropdown_allow_multiple")]
    public bool? DropdownAllowMultiple { get; set; }
}
