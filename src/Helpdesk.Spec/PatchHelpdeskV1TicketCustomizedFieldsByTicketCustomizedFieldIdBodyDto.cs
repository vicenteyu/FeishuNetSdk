using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk.Spec;
/// <summary>
/// 更新工单自定义字段 请求体
/// <para>该接口用于更新自定义字段。</para>
/// <para>接口ID：6955768699895660546</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/update-ticket-customized-field</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2fupdate-ticket-customized-field</para>
/// </summary>
public record PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdBodyDto
{
    /// <summary>
    /// <para>名称</para>
    /// <para>**示例值**："test dropdown"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("display_name")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// <para>字段在列表后台管理列表中的位置</para>
    /// <para>**示例值**："3"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("position")]
    public string? Position { get; set; }

    /// <summary>
    /// <para>描述</para>
    /// <para>**示例值**："下拉示例"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>是否可见</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// <para>是否必填</para>
    /// <para>**示例值**：false</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// <para>下拉列表选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("dropdown_options")]
    public DropdownOptionSuffix? DropdownOptions { get; set; }

    /// <summary></summary>
    public record DropdownOptionSuffix
    {
        /// <summary>
        /// <para>选项列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("children")]
        public DropdownOption[]? Children { get; set; }

        /// <summary></summary>
        public record DropdownOption
        {
            /// <summary>
            /// <para>选项ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("tag")]
            public string? Tag { get; set; }

            /// <summary>
            /// <para>展示名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>同上：选项列表，只适用于多层下拉列表（最多可以设置三级下拉列表）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("children")]
            public DropdownOption[]? Children { get; set; }
        }
    }
}
