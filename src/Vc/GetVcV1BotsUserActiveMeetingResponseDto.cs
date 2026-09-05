// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="GetVcV1BotsUserActiveMeetingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户活跃会议列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取用户活跃会议列表 响应体
/// <para>查询指定用户当前正在参与的所有会议，返回该用户处于活跃状态的会议列表，包含会议号、会议 ID 及会议标题等核心信息。</para>
/// <para>接口ID：7657481714696604903</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/user_active_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fuser_active_meeting</para>
/// </summary>
public record GetVcV1BotsUserActiveMeetingResponseDto
{
    /// <summary>
    /// <para>用户当前参与的活跃会议集合，每个元素包含会议号、会议ID及会议标题信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meetings")]
    public UserActiveMeetingInfo[]? Meetings { get; set; }

    /// <summary>
    /// <para>用户当前参与的活跃会议集合，每个元素包含会议号、会议ID及会议标题信息。</para>
    /// </summary>
    public record UserActiveMeetingInfo
    {
        /// <summary>
        /// <para>会议号</para>
        /// <para>必填：否</para>
        /// <para>示例值：987654321</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7628568141510692381</para>
        /// </summary>
        [JsonPropertyName("meeting_id")]
        public string? MeetingId { get; set; }

        /// <summary>
        /// <para>会议标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：Q3季度产品迭代评审会</para>
        /// </summary>
        [JsonPropertyName("meeting_title")]
        public string? MeetingTitle { get; set; }
    }
}
