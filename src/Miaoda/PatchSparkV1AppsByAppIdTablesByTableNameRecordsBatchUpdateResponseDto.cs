// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PatchSparkV1AppsByAppIdTablesByTableNameRecordsBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新数据表中的记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 批量更新数据表中的记录 响应体
/// <para>批量更新应用下的数据表中的记录，每条记录需包含主键如_id，单次最多500条。</para>
/// <para>接口ID：7620858064161803471</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/batch_update_table_records</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fbatch_update_table_records</para>
/// </summary>
public record PatchSparkV1AppsByAppIdTablesByTableNameRecordsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>更新的记录唯一ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];
}
