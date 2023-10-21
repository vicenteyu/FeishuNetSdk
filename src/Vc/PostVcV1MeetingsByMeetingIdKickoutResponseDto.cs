using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 移除参会人 响应体
/// <para>将参会人从会议中移除。</para>
/// <para>接口ID：6997003722790633474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/kickout</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fkickout</para>
/// </summary>
public record PostVcV1MeetingsByMeetingIdKickoutResponseDto
{
    /// <summary>
    /// <para>移除结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("kickout_results")]
    public MeetingParticipantResult[]? KickoutResults { get; set; }

    /// <summary>
    /// <para>移除结果</para>
    /// </summary>
    public record MeetingParticipantResult
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>用户类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：lark用户</item>
        /// <item>2：rooms用户</item>
        /// <item>3：文档用户</item>
        /// <item>4：neo单品用户</item>
        /// <item>5：neo单品游客用户</item>
        /// <item>6：pstn用户</item>
        /// <item>7：sip用户</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("user_type")]
        public int? UserType { get; set; }

        /// <summary>
        /// <para>移除结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：移除成功</item>
        /// <item>2：移除失败</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("result")]
        public int? Result { get; set; }
    }
}
