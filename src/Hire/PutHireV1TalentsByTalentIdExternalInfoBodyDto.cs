// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PutHireV1TalentsByTalentIdExternalInfoBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人才外部信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新人才外部信息 请求体
/// <para>更新人才外部信息，包含外部系统创建时间。</para>
/// <para>接口ID：7045100014603550721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fupdate</para>
/// </summary>
public record PutHireV1TalentsByTalentIdExternalInfoBodyDto
{
    /// <summary>
    /// <para>人才在外部系统的创建时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1639992265035</para>
    /// </summary>
    [JsonPropertyName("external_create_time")]
    public string ExternalCreateTime { get; set; } = string.Empty;
}
