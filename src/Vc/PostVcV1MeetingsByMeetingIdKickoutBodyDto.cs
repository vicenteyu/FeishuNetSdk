// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1MeetingsByMeetingIdKickoutBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除参会人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 移除参会人 请求体
/// <para>将参会人从会议中移除。</para>
/// <para>接口ID：6997003722790633474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/kickout</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fkickout</para>
/// </summary>
public record PostVcV1MeetingsByMeetingIdKickoutBodyDto
{
    /// <summary>
    /// <para>需移除的用户列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("kickout_users")]
    public MeetingUser[] KickoutUsers { get; set; } = Array.Empty<MeetingUser>();

    /// <summary>
    /// <para>需移除的用户列表</para>
    /// </summary>
    public record MeetingUser
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonPropertyName("id")]
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
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }
    }
}
