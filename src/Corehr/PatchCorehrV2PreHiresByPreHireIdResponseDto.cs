// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV2PreHiresByPreHireIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新待入职信息（推荐） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新待入职信息 响应体
/// <para>通过指定系统字段和自定义字段以更新待入职数据</para>
/// <para>接口ID：7357756972752715778</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fpatch</para>
/// </summary>
public record PatchCorehrV2PreHiresByPreHireIdResponseDto
{
    /// <summary>
    /// <para>待入职ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7345005664477775407</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string? PreHireId { get; set; }
}
