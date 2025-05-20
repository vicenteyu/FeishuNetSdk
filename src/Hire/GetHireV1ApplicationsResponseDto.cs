// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ApplicationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取投递列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取投递列表 响应体
/// <para>获取投递列表信息。可根据「招聘流程 ID」、「招聘阶段 ID」、「人才 ID」、「职位 ID」、「投递活跃状态」以及「投递更新时间」进行条件筛选。</para>
/// <para>接口ID：6964286393804865564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2flist</para>
/// </summary>
public record GetHireV1ApplicationsResponseDto : IPageableResponse<string>
{
    /// <summary>
    /// <para>投递 ID 列表，详情请参考：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public string[]? Items { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1721899407885_7395497752245422387</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
