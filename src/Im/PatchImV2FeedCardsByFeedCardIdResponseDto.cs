namespace FeishuNetSdk.Im;
/// <summary>
/// 即时提醒 响应体
/// <para>即时提醒能力是飞书在消息列表中提供的强提醒能力，当有重要通知或任务需要及时触达用户，可将群组或机器人对话在消息列表中置顶展示，打开飞书首页即可处理重要任务。</para>
/// <para>接口ID：7291232621641039875</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/feed_card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fpatch</para>
/// </summary>
public record PatchImV2FeedCardsByFeedCardIdResponseDto
{
    /// <summary>
    /// <para>失败原因</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_user_reasons")]
    public FailedReason[]? FailedUserReasons { get; set; }

    /// <summary>
    /// <para>失败原因</para>
    /// </summary>
    public record FailedReason
    {
        /// <summary>
        /// <para>错误码</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：The user is not in the chat</para>
        /// </summary>
        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// <para>用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_679eaeb583654bff73fefcc6e6371301</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
