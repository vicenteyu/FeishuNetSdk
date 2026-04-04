// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdSqlCommandsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行 SQL 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 执行 SQL 响应体
/// <para>在应用下执行 SQL。</para>
/// <para>接口ID：7620858064161852623</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fsql_commands</para>
/// </summary>
public record PostSparkV1AppsByAppIdSqlCommandsResponseDto
{
    /// <summary>
    /// <para>如果是 SELECT 命令，返回的是查询结果的 JSON 序列化字符串。如果是其他无返回的命令，如 DELETE 等，result 为空</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\"}]</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = string.Empty;
}
