// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationApplicationAppVersionAuditV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>应用审核 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 应用审核 事件体
/// <para>通过订阅该事件，可接收应用审核（通过 / 拒绝）事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application.app_version&amp;event=audit)</para>
/// <para>接口ID：7005118068771389443</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/audit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fevents%2faudit</para>
/// </summary>
public record ApplicationApplicationAppVersionAuditV6EventBodyDto() : EventBodyDto("application.application.app_version.audit_v6")
{
    /// <summary>
    /// <para>通过 / 拒绝应用审核的管理员 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>被审核的应用版本 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string? VersionId { get; set; }

    /// <summary>
    /// <para>应用创建者的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public UserIdSuffix? CreatorId { get; set; }

    /// <summary>
    /// <para>审核应用的 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>审核通过 / 拒绝</para>
    /// <para>**可选值有**：</para>
    /// <para>audited:审核通过,reject:审核拒绝</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>audited：审核通过</item>
    /// <item>reject：审核拒绝</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>
    /// <para>审核信息，当审核拒绝时，管理员填写的拒绝理由</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// <para>应用审核的方式</para>
    /// <para>**可选值有**：</para>
    /// <para>administrator:管理员审核,auto:自动免审</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>administrator：管理员审核</item>
    /// <item>auto：自动免审</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("audit_source")]
    public string? AuditSource { get; set; }
}
