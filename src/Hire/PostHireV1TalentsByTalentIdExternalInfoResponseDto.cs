// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentsByTalentIdExternalInfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建人才外部信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建人才外部信息 响应体
/// <para>创建人才外部信息。</para>
/// <para>接口ID：7045099225022185474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fcreate</para>
/// </summary>
public record PostHireV1TalentsByTalentIdExternalInfoResponseDto
{
    /// <summary>
    /// <para>人才外部信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_info")]
    public TalentExternalInfo? ExternalInfo { get; set; }

    /// <summary>
    /// <para>人才外部信息</para>
    /// </summary>
    public record TalentExternalInfo
    {
        /// <summary>
        /// <para>人才 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7043758982146345223</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>人才在外部系统的创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608467675393</para>
        /// </summary>
        [JsonPropertyName("external_create_time")]
        public string? ExternalCreateTime { get; set; }
    }
}
