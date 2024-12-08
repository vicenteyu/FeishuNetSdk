// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ExternalBackgroundChecksBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询外部背调列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询外部背调列表 请求体
/// <para>可根据外部投递 ID 或外部背调 ID 列表查询外部背调信息。</para>
/// <para>接口ID：7407298680641028099</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_background_check/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fbatch_query</para>
/// </summary>
public record PostHireV1ExternalBackgroundChecksBatchQueryBodyDto
{
    /// <summary>
    /// <para>外部背调 ID 列表，当传此值时，仅以此值作为条件查询，其他查询条件不生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956660</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("external_background_check_id_list")]
    public string[]? ExternalBackgroundCheckIdList { get; set; }
}
