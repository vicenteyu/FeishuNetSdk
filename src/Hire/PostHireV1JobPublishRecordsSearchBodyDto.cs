// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1JobPublishRecordsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位广告发布记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位广告发布记录 请求体
/// <para>获取职位广告发布记录。</para>
/// <para>接口ID：7098526921116745729</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_publish_record%2fsearch</para>
/// </summary>
public record PostHireV1JobPublishRecordsSearchBodyDto
{
    /// <summary>
    /// <para>渠道 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7047318856652261676</para>
    /// </summary>
    [JsonPropertyName("job_channel_id")]
    public string JobChannelId { get; set; } = string.Empty;
}
