// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSearchV2AppBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Search;
/// <summary>
/// 搜索应用 请求体
/// <para>用户可以通过关键字搜索到可见应用，应用可见性与套件内搜索一致。</para>
/// <para>接口ID：7208771563588075523</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fapp%2fcreate</para>
/// </summary>
public record PostSearchV2AppBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试应用</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
}
