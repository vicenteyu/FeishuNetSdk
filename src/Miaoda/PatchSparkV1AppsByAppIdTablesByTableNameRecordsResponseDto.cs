// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PatchSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>按条件更新数据表中的记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 按条件更新数据表中的记录 响应体
/// <para>将数据表中符合filter条件的记录更新为record参数指定的内容。</para>
/// <para>接口ID：7620858064161787087</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/patch_table_records</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fpatch_table_records</para>
/// </summary>
public record PatchSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto
{
    /// <summary>
    /// <para>更新的记录唯一ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];
}
