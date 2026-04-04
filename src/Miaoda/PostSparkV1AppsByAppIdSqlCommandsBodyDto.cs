// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdSqlCommandsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行 SQL 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 执行 SQL 请求体
/// <para>在应用下执行 SQL。</para>
/// <para>接口ID：7620858064161852623</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fsql_commands</para>
/// </summary>
public record PostSparkV1AppsByAppIdSqlCommandsBodyDto
{
    /// <summary>
    /// <para>要执行的 SQL 语句</para>
    /// <para>必填：是</para>
    /// <para>示例值：SELECT name FROM student</para>
    /// </summary>
    [JsonPropertyName("sql")]
    public string Sql { get; set; } = string.Empty;
}
