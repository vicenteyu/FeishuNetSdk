// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 批量获取记录 请求体
/// <para>通过多个记录 ID 查询记录信息。</para>
/// <para>## 使用限制</para>
/// <para>该接口最多支持查询 100 条记录。</para>
/// <para>接口ID：7386702252390268956</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_get</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetBodyDto
{
    /// <summary>
    /// <para>记录 ID 列表。调用[查询记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search)获取。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>此次调用中使用的用户 id 的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：以user_id来识别用户</item>
    /// <item>union_id：以union_id来识别用户</item>
    /// <item>open_id：以open_id来识别用户</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("user_id_type")]
    public string? UserIdType { get; set; }

    /// <summary>
    /// <para>是否返回记录的分享链接。可选值：</para>
    /// <para>- true：返回分享链接</para>
    /// <para>- false：不返回分享链接</para>
    /// <para>**默认值**：false</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("with_shared_url")]
    public bool? WithSharedUrl { get; set; }

    /// <summary>
    /// <para>是否返回自动计算的字段。可选值：</para>
    /// <para>- true：返回自动计算的字段</para>
    /// <para>- false：不返回自动计算的字段</para>
    /// <para>**默认值**：false</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("automatic_fields")]
    public bool? AutomaticFields { get; set; }
}
