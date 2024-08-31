// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发布职位广告 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 发布职位广告 请求体
/// <para>支持把职位广告发布上线至招聘官网、内推平台。</para>
/// <para>## 注意事项</para>
/// <para>调用此接口前，需先打开「飞书招聘」-「设置」-「职位管理」-「职位设置」-「通过 API 同步职位开关」开关。</para>
/// <para>接口ID：7012986483075547137</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/publish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fadvertisement%2fpublish</para>
/// </summary>
public record PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto
{
    /// <summary>
    /// <para>招聘渠道 ID，选择要发布的招聘官网，单次仅可发布 1 个渠道：</para>
    /// <para>- 当发布内推平台时，可使用 job_channel_id = 3 来发布</para>
    /// <para>- 官网渠道的 ID 可通过[获取招聘官网列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website/list)」接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956631</para>
    /// </summary>
    [JsonPropertyName("job_channel_id")]
    public string? JobChannelId { get; set; }
}
