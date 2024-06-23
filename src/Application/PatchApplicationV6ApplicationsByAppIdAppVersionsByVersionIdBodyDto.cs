// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchApplicationV6ApplicationsByAppIdAppVersionsByVersionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用审核状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用审核状态 请求体
/// <para>通过接口来更新应用版本的审核结果：通过后应用可以直接上架；拒绝后则开发者可以看到拒绝理由，并在修改后再次申请发布。</para>
/// <para>接口ID：6989432329400303617</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdAppVersionsByVersionIdBodyDto
{
    /// <summary>
    /// <para>版本状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知状态</item>
    /// <item>1：审核通过</item>
    /// <item>2：审核拒绝</item>
    /// <item>3：审核中</item>
    /// <item>4：未提交审核</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }
}
