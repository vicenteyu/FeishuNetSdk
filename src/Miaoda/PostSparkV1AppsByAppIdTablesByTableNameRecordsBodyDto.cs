// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向数据表中添加或更新记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 向数据表中添加或更新记录 请求体
/// <para>向应用下的数据表中添加或更新记录。</para>
/// <para>接口ID：7620858064161770703</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/post_table_records</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fpost_table_records</para>
/// </summary>
public record PostSparkV1AppsByAppIdTablesByTableNameRecordsBodyDto
{
    /// <summary>
    /// <para>要插入的数据记录列表（JSON数组的字符串形式），单次支持最大记录数量500条</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string Records { get; set; } = string.Empty;
}
