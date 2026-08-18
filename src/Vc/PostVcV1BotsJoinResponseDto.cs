// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="PostVcV1BotsJoinResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加入会议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 加入会议 响应体
/// <para>通过会议号将机器人加入指定的视频会议。调用成功后会返回会议 ID，该 ID 可用于后续的机器人离会、发送会中消息等操作。</para>
/// <para>接口ID：7672664994767015159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/join</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fjoin</para>
/// </summary>
public record PostVcV1BotsJoinResponseDto
{
    /// <summary>
    /// <para>机器人加入的会议详情信息，包含会议唯一标识、会议号、开始时间及会议主题等核心数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"id":"mtg_1716187200_9c8d7e6f","meeting_no":"98765432","start_time":"2024-05-20 14:00:00","topic":"AI产品技术研讨会"}</para>
    /// </summary>
    [JsonPropertyName("meeting")]
    public BotMeetingInfo? Meeting { get; set; }

    /// <summary>
    /// <para>机器人加入的会议详情信息，包含会议唯一标识、会议号、开始时间及会议主题等核心数据</para>
    /// </summary>
    public record BotMeetingInfo
    {
        /// <summary>
        /// <para>会议唯一标识ID，系统自动生成，全局唯一。可通过会议创建接口或会议列表查询接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：mtg_1698745200_8a9b7c6d</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会议号，用于用户快速加入会议，支持数字或字母组合格式。可在会议创建时指定或由系统自动生成</para>
        /// <para>必填：否</para>
        /// <para>示例值：87654321</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议开始时间，格式为YYYY-MM-DD HH:mm:ss，时区为UTC+8</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-10-31 14:30:00</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>会议主题，用于标识会议内容，支持中英文及特殊字符，长度不超过128个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：Q4季度产品规划评审会</para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }
    }

    /// <summary>
    /// <para>成功入会的机器人用户信息，包含用户唯一标识及用户类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"id":"ou_8d7c6b5a4f3e2d1c0b9a8f7e6d5c4b3a","user_type":1}</para>
    /// </summary>
    [JsonPropertyName("join_user")]
    public MeetingUser? JoinUser { get; set; }

    /// <summary>
    /// <para>成功入会的机器人用户信息，包含用户唯一标识及用户类型</para>
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
