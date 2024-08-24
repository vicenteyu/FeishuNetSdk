// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="PostMessageV4BatchSendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量发送消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 批量发送消息 响应体
/// <para>给多个用户或者多个部门中的成员发送消息。</para>
/// <para>接口ID：6907569743419555842</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/send-messages-in-batches</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDO1EjL3gTNx4yN4UTM</para>
/// </summary>
public record PostMessageV4BatchSendResponseDto
{
    /// <summary>
    /// <para>批量消息任务 ID，批量发送消息的任务唯一标识，以 `bm-` 开头（与一般的消息 ID `om_` 不同，注意区分）。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>不合法的部门 ID 列表。请求时传入的 department_ids 列表内存在部分部门 ID 无效时，会将这部分 ID 通过该参数返回，同时会向正确的部门 ID 批量发送消息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_department_ids")]
    public string[]? InvalidDepartmentIds { get; set; }

    /// <summary>
    /// <para>不合法的 open_id 列表。请求时传入的 open_ids 列表内存在部分用户 open_id 无效时，会将这部分 ID 通过该参数返回，同时会向正确的用户 ID 批量发送消息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_open_ids")]
    public string[]? InvalidOpenIds { get; set; }

    /// <summary>
    /// <para>不合法的 user_id 列表。请求时传入的 user_ids 列表内存在部分用户 user_id 无效时，会将这部分 ID 通过该参数返回，同时会向正确的用户 ID 批量发送消息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_user_ids")]
    public string[]? InvalidUserIds { get; set; }

    /// <summary>
    /// <para>不合法的 union_id 列表。请求时传入的 union_ids 列表内存在部分用户 union_id 无效时，会将这部分 ID 通过该参数返回，同时会向正确的用户 ID 批量发送消息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_union_ids")]
    public string[]? InvalidUnionIds { get; set; }
}
