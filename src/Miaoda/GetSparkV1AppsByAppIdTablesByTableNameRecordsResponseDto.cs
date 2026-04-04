// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询数据表数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 查询数据表数据记录 响应体
/// <para>查询应用下的数据表数据记录，包括指定列、字段值及分页信息，适用于需要获取应用下某数据表数据的记录、展示等场景。</para>
/// <para>接口ID：7620858064161885391</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/get_table_record_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fget_table_record_list</para>
/// </summary>
public record GetSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>符合条件的记录总数</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// <para>数据记录列表，格式为数组序列化后的 JSONString</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]</para>
    /// </summary>
    [JsonPropertyName("items")]
    public string Items { get; set; } = string.Empty;
}
