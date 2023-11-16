namespace FeishuNetSdk.Im;
/// <summary>
/// 查询批量消息整体进度 响应体
/// <para>该接口在[查询批量消息推送和阅读人数](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/batch_message/read_user)查询结果的基础上，增加了批量请求中有效的user id数量以及消息撤回进度数据。</para>
/// <para>接口ID：7039583318606217220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/get_progress</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fget_progress</para>
/// </summary>
public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDto
{
    /// <summary>
    /// <para>消息发送进度</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("batch_message_send_progress")]
    public GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageSendProgress? BatchMessageSendProgress { get; set; }

    /// <summary>
    /// <para>消息发送进度</para>
    /// </summary>
    public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageSendProgress
    {
        /// <summary>
        /// <para>批量请求中有效的userid数量(包含机器人不可见用户)</para>
        /// <para>**注意**：</para>
        /// <para>当valid_user_ids_count为0有两种情况：</para>
        /// <para>* 批量任务还没有开始被调度（请等待一会再调用该接口）</para>
        /// <para>* 批量发送消息时传入的所有openIDs、employeID、departmentiIDs都不包含有效的用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：204</para>
        /// </summary>
        [JsonPropertyName("valid_user_ids_count")]
        public int? ValidUserIdsCount { get; set; }

        /// <summary>
        /// <para>已经成功给用户发送成功的消息数量</para>
        /// <para>**注意**：最终success_user_ids_count不一定等于valid_user_ids_count, 因为valid_user_ids_count包含了对机器人不可见的用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：200</para>
        /// </summary>
        [JsonPropertyName("success_user_ids_count")]
        public int? SuccessUserIdsCount { get; set; }

        /// <summary>
        /// <para>已读信息用户数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：150</para>
        /// </summary>
        [JsonPropertyName("read_user_ids_count")]
        public int? ReadUserIdsCount { get; set; }
    }

    /// <summary>
    /// <para>消息撤回进度</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("batch_message_recall_progress")]
    public GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageRecallProgress? BatchMessageRecallProgress { get; set; }

    /// <summary>
    /// <para>消息撤回进度</para>
    /// </summary>
    public record GetImV1BatchMessagesByBatchMessageIdGetProgressResponseDtoBatchMessageRecallProgress
    {
        /// <summary>
        /// <para>该条批量消息是否被执行过撤回操作</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("recall")]
        public bool? Recall { get; set; }

        /// <summary>
        /// <para>已经成功撤回的消息数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("recall_count")]
        public int? RecallCount { get; set; }
    }
}
