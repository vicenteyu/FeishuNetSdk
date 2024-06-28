// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-29
//
// Last Modified By : yxr
// Last Modified On : 2024-06-29
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceEnvironmentVariablesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询环境变量列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询环境变量列表 请求体
/// <para>查询基于飞书应用引擎开发的应用的环境变量列表</para>
/// <para>接口ID：7385474062586298370</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-environment_variable/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-environment_variable%2fquery</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceEnvironmentVariablesQueryBodyDto
{
    /// <summary>
    /// <para>过滤条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public EnvironmentVariableFilter? Filter { get; set; }

    /// <summary>
    /// <para>过滤条件</para>
    /// </summary>
    public record EnvironmentVariableFilter
    {
        /// <summary>
        /// <para>模糊查询关键词</para>
        /// <para>必填：否</para>
        /// <para>示例值：Sample Text</para>
        /// </summary>
        [JsonPropertyName("quick_query")]
        public string? QuickQuery { get; set; }
    }

    /// <summary>
    /// <para>限制的条数，默认为 500，不可超过 500</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>最大值：500</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// <para>返回记录的偏移量，默认为 0，即从查询到的第一个记录开始返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最大值：9223372036854775807</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }
}
