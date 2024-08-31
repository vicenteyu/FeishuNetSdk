// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentsByTalentIdExternalInfoBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建人才外部信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建人才外部信息 请求体
/// <para>创建外部人才，可将已存在人才标记为外部人才，并写入外部系统创建时间。</para>
/// <para>接口ID：7045099225022185474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fcreate</para>
/// </summary>
public record PostHireV1TalentsByTalentIdExternalInfoBodyDto
{
    /// <summary>
    /// <para>人才在外部系统的创建时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1639992265035</para>
    /// </summary>
    [JsonPropertyName("external_create_time")]
    public string ExternalCreateTime { get; set; } = string.Empty;
}
