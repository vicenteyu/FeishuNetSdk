// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchVcV1MeetingsByMeetingIdRecordingSetPermissionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>授权录制文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 授权录制文件 请求体
/// <para>将一个会议的录制文件授权给组织、用户或公开到公网。</para>
/// <para>接口ID：6960861158129025027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/set_permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fset_permission</para>
/// </summary>
public record PatchVcV1MeetingsByMeetingIdRecordingSetPermissionBodyDto
{
    /// <summary>
    /// <para>授权对象列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("permission_objects")]
    public RecordingPermissionObject[] PermissionObjects { get; set; } = [];

    /// <summary>
    /// <para>授权对象列表</para>
    /// </summary>
    public record RecordingPermissionObject
    {
        /// <summary>
        /// <para>授权对象ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>授权对象类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：用户授权（id字段填入用户ID）</item>
        /// <item>2：群组授权（id字段填入群组open_chat_id）</item>
        /// <item>3：租户内授权（id字段不填）</item>
        /// <item>4：公网授权（id字段不填）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// <para>权限</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：查看</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("permission")]
        public int Permission { get; set; }
    }

    /// <summary>
    /// <para>授权或者取消授权，默认授权</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：授权</item>
    /// <item>1：取消授权</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("action_type")]
    public int? ActionType { get; set; }
}
