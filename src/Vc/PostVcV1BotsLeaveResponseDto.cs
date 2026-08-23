// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="PostVcV1BotsLeaveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离开会议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 离开会议 响应体
/// <para>机器人可通过会议 ID 主动离开指定的视频会议。调用成功后，将返回该机器人对应的用户信息。</para>
/// <para>接口ID：7672664994766998775</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/leave</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fleave</para>
/// </summary>
public record PostVcV1BotsLeaveResponseDto
{
    /// <summary>
    /// <para>离开用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("leave_user")]
    public MeetingUser? LeaveUser { get; set; }

    /// <summary>
    /// <para>离开用户信息</para>
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
        /// <item>1：lark用户</item>
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
