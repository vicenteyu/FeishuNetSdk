// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-08
//
// Last Modified By : yxr
// Last Modified On : 2024-10-08
// ************************************************************************
// <copyright file="PostCorehrV2JobGradesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职等 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建职等 响应体
/// <para>创建职等</para>
/// <para>接口ID：7422326822924582914</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fcreate</para>
/// </summary>
public record PostCorehrV2JobGradesResponseDto
{
    /// <summary>
    /// <para>职等ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345678</para>
    /// </summary>
    [JsonPropertyName("grade_id")]
    public string? GradeId { get; set; }
}
