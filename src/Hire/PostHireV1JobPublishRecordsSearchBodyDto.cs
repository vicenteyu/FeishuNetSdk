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
/// <para>根据招聘渠道 ID 批量获取职位广告发布记录。</para>
/// <para>接口ID：7098526921116745729</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_publish_record%2fsearch</para>
/// </summary>
public record PostHireV1JobPublishRecordsSearchBodyDto
{
    /// <summary>
    /// <para>招聘渠道 ID</para>
    /// <para>- 官网 ID：可通过[获取招聘官网列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website/list)接口获取</para>
    /// <para>- 三方渠道 ID：可通过[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中「三方渠道 ID」枚举定义</para>
    /// <para>- 猎头渠道 ID ： "2"</para>
    /// <para>- 内推渠道 ID ： "3"</para>
    /// <para>必填：是</para>
    /// <para>示例值：7047318856652261676</para>
    /// </summary>
    [JsonPropertyName("job_channel_id")]
    public string JobChannelId { get; set; } = string.Empty;
}
