// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="PostVcV1BotsJoinBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加入会议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 加入会议 请求体
/// <para>通过会议号将机器人加入指定的视频会议。调用成功后会返回会议 ID，该 ID 可用于后续的[离开会议](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/leave)、[发送会中消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/message)等操作。</para>
/// <para>接口ID：7672664994767015159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/join</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fjoin</para>
/// </summary>
public record PostVcV1BotsJoinBodyDto
{
    /// <summary>
    /// <para>机器人入会方式。取值范围为 1~100；当前仅支持取值 1，表示通过会议号入会，join_identify 中需传入 meeting_no 字段。取值 2~100 暂不支持。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最大值：100</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("join_type")]
    public int JoinType { get; set; }

    /// <summary>
    /// <para>入会标识信息。当 join_type=1 时，需传入 meeting_no 字段。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("join_identify")]
    public JoinIdentifySuffix JoinIdentify { get; set; } = new();

    /// <summary>
    /// <para>入会标识信息。当 join_type=1 时，需传入 meeting_no 字段。</para>
    /// </summary>
    public record JoinIdentifySuffix
    {
        /// <summary>
        /// <para>会议号，用于定位需加入的目标会议。可通过会议创建接口或会议列表查询接口获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：MTG202405201030001</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }
    }

    /// <summary>
    /// <para>会议密码。目标会议未设置密码时无需传入；若会议设置了密码，未传入或传入错误密码将无法入会。可通过会议创建接口或会议详情查询接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：******</para>
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// <para>邀请-入会链路的关联标识。从[邀请机器人入会](https://open.feishu.cn/document/server-docs/vc-v1/supportEventsList/meeting_invited)事件获取；仅在响应邀请入会时原样回传。未传入时按普通入会链路处理，不进行邀请关联。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7c9e6679-7425-40de-944b-e07fc1f90ae7</para>
    /// </summary>
    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }
}
