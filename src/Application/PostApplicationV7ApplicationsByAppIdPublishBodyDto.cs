// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PostApplicationV7ApplicationsByAppIdPublishBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提交发布自建应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 提交发布自建应用 请求体
/// <para>自建应用提交应用发布，如果当前自建应用没有待发布的版本，则会自动创建一个版本，如果有待发布的版本，则直接提交该版本。</para>
/// <para>接口ID：7621030901518552023</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-publish/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-publish%2fcreate</para>
/// </summary>
public record PostApplicationV7ApplicationsByAppIdPublishBodyDto
{
    /// <summary>
    /// <para>移动端默认能力</para>
    /// <para>**注意**：如果应用开启了小程序、机器人或者网页应用能力，则该参数必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：gadget</para>
    /// <para>可选值：<list type="bullet">
    /// <item>gadget：小程序</item>
    /// <item>web_app：网页应用</item>
    /// <item>bot：机器人</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("mobile_default_ability")]
    public string? MobileDefaultAbility { get; set; }

    /// <summary>
    /// <para>PC端默认能力</para>
    /// <para>**注意**：如果应用开启了小程序、机器人或者网页应用能力，则该参数必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：gadget</para>
    /// <para>可选值：<list type="bullet">
    /// <item>gadget：小程序</item>
    /// <item>web_app：网页应用</item>
    /// <item>bot：机器人</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("pc_default_ability")]
    public string? PcDefaultAbility { get; set; }

    /// <summary>
    /// <para>申请理由（500字符以内）</para>
    /// <para>必填：是</para>
    /// <para>示例值：更新了移动端默认应用能力</para>
    /// </summary>
    [JsonPropertyName("remark")]
    public string Remark { get; set; } = string.Empty;

    /// <summary>
    /// <para>更新描述（500字符以内）</para>
    /// <para>必填：是</para>
    /// <para>示例值：更新了小程序的头像</para>
    /// </summary>
    [JsonPropertyName("changelog")]
    public string Changelog { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1.1.1</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
