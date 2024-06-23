// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建待入职人员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建待入职人员 响应体
/// <para>创建待入职人员。</para>
/// <para>接口ID：7160511371865014276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fcreate</para>
/// </summary>
public record PostCorehrV2PreHiresResponseDto
{
    /// <summary>
    /// <para>待入职 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6966234786251671053</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string? PreHireId { get; set; }
}
