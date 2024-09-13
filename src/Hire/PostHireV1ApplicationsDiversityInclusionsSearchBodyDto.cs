// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1ApplicationsDiversityInclusionsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取申请表附加信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取申请表附加信息 请求体
/// <para>获取候选人的申请表附加信息。支持通过投递 ID 或者人才 ID 进行查询。</para>
/// <para>接口ID：7232192298414292993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fdiversity_inclusion%2fsearch</para>
/// </summary>
public record PostHireV1ApplicationsDiversityInclusionsSearchBodyDto
{
    /// <summary>
    /// <para>人才 ID 列表，如何获取人才 ID 请参考[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)</para>
    /// <para>**特殊说明：**</para>
    /// <para>- 当通过人才 ID 列表查询时会返回对应人才最新投递的申请表附加信息。</para>
    /// <para>- 当人才 ID 列表或投递 ID 列表同时存在将以人才 ID 列表为准。</para>
    /// <para>- 当人才 ID 列表和投递 ID 列表都没有填写时则返回空数据。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("talent_ids")]
    public string[]? TalentIds { get; set; }

    /// <summary>
    /// <para>投递 ID 列表，如何获取投递 ID 请参考[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：30</para>
    /// </summary>
    [JsonPropertyName("application_ids")]
    public string[]? ApplicationIds { get; set; }
}
