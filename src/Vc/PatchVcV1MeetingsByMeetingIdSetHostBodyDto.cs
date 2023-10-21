using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 设置主持人 请求体
/// <para>设置会议的主持人。</para>
/// <para>接口ID：6921909217674805275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/set_host</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fset_host</para>
/// </summary>
public record PatchVcV1MeetingsByMeetingIdSetHostBodyDto
{
    /// <summary>
    /// <para>将要设置的主持人</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("host_user")]
    public MeetingUser HostUser { get; set; } = new();

    /// <summary>
    /// <para>将要设置的主持人</para>
    /// </summary>
    public record MeetingUser
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
        /// <item>1：飞书用户</item>
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
    }

    /// <summary>
    /// <para>当前主持人（CAS并发安全：如果和会中当前主持人不符则会设置失败，可使用返回的最新数据重新设置）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("old_host_user")]
    public MeetingUser? OldHostUser { get; set; }
}
