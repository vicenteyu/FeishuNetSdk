// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="PutBitableV1AppsByAppTokenWorkflowsByWorkflowIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自动化流程状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新自动化流程状态 请求体
/// <para>开启或关闭自动化流程。</para>
/// <para>接口ID：7447033368182587393</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-workflow/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-workflow%2fupdate</para>
/// </summary>
public record PutBitableV1AppsByAppTokenWorkflowsByWorkflowIdBodyDto
{
    /// <summary>
    /// <para>自动化状态。可选值：</para>
    /// <para>- Enable：开启自动化流程</para>
    /// <para>- Disable：关闭自动化流程</para>
    /// <para>必填：是</para>
    /// <para>示例值：Enable</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}
