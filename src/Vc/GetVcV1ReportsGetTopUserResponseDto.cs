// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1ReportsGetTopUserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Top 用户列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取 Top 用户列表 响应体
/// <para>获取一段时间内组织内会议使用的 Top 用户列表。</para>
/// <para>接口ID：6921909217674723355</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/report/get_top_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freport%2fget_top_user</para>
/// </summary>
public record GetVcV1ReportsGetTopUserResponseDto
{
    /// <summary>
    /// <para>top用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("top_user_report")]
    public ReportTopUser[]? TopUserReports { get; set; }

    /// <summary>
    /// <para>top用户列表</para>
    /// </summary>
    public record ReportTopUser
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

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

        /// <summary>
        /// <para>会议数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("meeting_count")]
        public string? MeetingCount { get; set; }

        /// <summary>
        /// <para>会议时长（单位min）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3000</para>
        /// </summary>
        [JsonPropertyName("meeting_duration")]
        public string? MeetingDuration { get; set; }
    }
}
