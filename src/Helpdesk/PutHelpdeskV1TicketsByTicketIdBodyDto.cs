// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutHelpdeskV1TicketsByTicketIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新工单详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 更新工单详情 请求体
/// <para>该接口用于更新服务台工单详情。只会更新数据，不会触发相关操作。如修改工单状态到关单，不会关闭聊天页面。仅支持自建应用。要更新的工单字段必须至少输入一项。</para>
/// <para>注意事项：</para>
/// <para>user_access_token 访问，需要操作者有当前工单的权限，属于服务台的客服（并且具有该工单的权限）、管理员或所有者</para>
/// <para>接口ID：6955768699895824386</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fupdate</para>
/// </summary>
public record PutHelpdeskV1TicketsByTicketIdBodyDto
{
    /// <summary>
    /// <para>工单新status，status对应具体的含义如下：1: 待响应, 2: 处理中, 3: 排队中, 4: 待定, 5: 待用户响应, 50: 机器人关闭工单, 51: 人工关闭工单</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>新标签名</para>
    /// <para>必填：否</para>
    /// <para>示例值：abc</para>
    /// </summary>
    [JsonPropertyName("tag_names")]
    public string[]? TagNames { get; set; }

    /// <summary>
    /// <para>新评论</para>
    /// <para>必填：否</para>
    /// <para>示例值：good</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_fields")]
    public CustomizedFieldDisplayItem[]? CustomizedFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record CustomizedFieldDisplayItem
    {
        /// <summary>
        /// <para>自定义字段ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>自定义字段值</para>
        /// <para>必填：否</para>
        /// <para>示例值：value</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// <para>键名</para>
        /// <para>必填：否</para>
        /// <para>示例值：key</para>
        /// </summary>
        [JsonPropertyName("key_name")]
        public string? KeyName { get; set; }
    }

    /// <summary>
    /// <para>ticket stage</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("ticket_type")]
    public int? TicketType { get; set; }

    /// <summary>
    /// <para>工单是否解决，1: 未解决, 2: 已解决</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("solved")]
    public int? Solved { get; set; }

    /// <summary>
    /// <para>工单来源渠道ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("channel")]
    public int? Channel { get; set; }
}
