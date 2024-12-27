// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TestsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取笔试列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取笔试列表 请求体
/// <para>批量获取人才在投递流程中的笔试信息。如作答状态、笔试得分等。</para>
/// <para>接口ID：7127207246887796740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftest%2fsearch</para>
/// </summary>
public record PostHireV1TestsSearchBodyDto
{
    /// <summary>
    /// <para>投递 ID 列表，可通过[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7018467800193304840</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("application_id_list")]
    public string[]? ApplicationIdList { get; set; }

    /// <summary>
    /// <para>笔试最早开始时间（毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1608725989000</para>
    /// </summary>
    [JsonPropertyName("test_start_time_min")]
    public string? TestStartTimeMin { get; set; }

    /// <summary>
    /// <para>笔试最晚开始时间（毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1608726999000</para>
    /// </summary>
    [JsonPropertyName("test_start_time_max")]
    public string? TestStartTimeMax { get; set; }
}
