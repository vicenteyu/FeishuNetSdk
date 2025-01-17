// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询批量消息整体进度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 查询批量消息整体进度 响应体
/// <para>[批量发送消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)或者[批量撤回消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/batch_message/delete)后，可通过该接口查询消息的发送进度和撤回进度。</para>
/// <para>## 注意事项</para>
/// <para>- 只能查询 30 天内，通过[批量发送消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)接口发送的消息。</para>
/// <para>- 该接口返回的数据为查询时刻的快照数据。</para>
/// <para>接口ID：7039583318606217220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/get_progress</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fget_progress</para>
/// </summary>
public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto
{
    /// <summary>
    /// <para>批量发送消息的进度。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("batch_message_send_progress")]
    public GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageSendProgress? BatchMessageSendProgress { get; set; }

    /// <summary>
    /// <para>批量发送消息的进度。</para>
    /// </summary>
    public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageSendProgress
    {
        /// <summary>
        /// <para>批量发送消息请求中，有效的用户数量。</para>
        /// <para>**注意**：</para>
        /// <para>- 不在当前机器人的通讯录权限数据范围内但有效的用户，也会被统计在内。了解通讯录数据权限范围参见[配置应用数据权限](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/configure-app-data-permissions)。</para>
        /// <para>- `valid_user_ids_count` 值为 0 有两种情况：</para>
        /// <para>- 批量发送消息接口为异步调用，任务还没有开始被调度便查询当前接口则取值为 0。建议你等待片刻再调用该接口。</para>
        /// <para>- 批量发送消息时传入的所有 department_ids、open_ids、user_ids、union_ids 均未包含有效的用户。</para>
        /// <para>必填：否</para>
        /// <para>示例值：204</para>
        /// </summary>
        [JsonPropertyName("valid_user_ids_count")]
        public int? ValidUserIdsCount { get; set; }

        /// <summary>
        /// <para>已向用户成功发送消息的数量。</para>
        /// <para>**注意**：最终 `success_user_ids_count` 不一定等于 `valid_user_ids_count`，原因是 `valid_user_ids_count` 包含了对机器人不可见的用户。</para>
        /// <para>必填：否</para>
        /// <para>示例值：200</para>
        /// </summary>
        [JsonPropertyName("success_user_ids_count")]
        public int? SuccessUserIdsCount { get; set; }

        /// <summary>
        /// <para>已读消息的用户数量。</para>
        /// <para>必填：否</para>
        /// <para>示例值：150</para>
        /// </summary>
        [JsonPropertyName("read_user_ids_count")]
        public int? ReadUserIdsCount { get; set; }
    }

    /// <summary>
    /// <para>批量撤回消息的进度。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("batch_message_recall_progress")]
    public GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageRecallProgress? BatchMessageRecallProgress { get; set; }

    /// <summary>
    /// <para>批量撤回消息的进度。</para>
    /// </summary>
    public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageRecallProgress
    {
        /// <summary>
        /// <para>当前查询的批量发送消息任务是否执行过撤回操作。可能值：</para>
        /// <para>- true：消息被撤回过</para>
        /// <para>- false：消息未被撤回过</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("recall")]
        public bool? Recall { get; set; }

        /// <summary>
        /// <para>已经成功撤回的消息数量。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("recall_count")]
        public int? RecallCount { get; set; }
    }
}
