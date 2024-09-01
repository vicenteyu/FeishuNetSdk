// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationApplicationAppVersionPublishRevokeV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回应用发布申请 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 撤回应用发布申请 事件体
/// <para>通过订阅该事件，可接收应用撤回发布申请事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application.app_version&amp;event=publish_revoke)</para>
/// <para>接口ID：7005118068771373059</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/publish_revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fevents%2fpublish_revoke</para>
/// </summary>
public record ApplicationApplicationAppVersionPublishRevokeV6EventBodyDto() : EventBodyDto("application.application.app_version.publish_revoke_v6")
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public UserIdSuffix? CreatorId { get; set; }

    /// <summary>
    /// <para>撤回应用的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>撤回应用的版本 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string? VersionId { get; set; }
}
