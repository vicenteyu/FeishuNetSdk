// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PostApaasV1WorkspacesByWorkspaceIdSqlCommandsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行SQL 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 执行SQL 响应体
/// <para>在工作空间下执行 SQL 语句</para>
/// <para>接口ID：7574027220335840199</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace%2fsql_commands</para>
/// </summary>
public record PostApaasV1WorkspacesByWorkspaceIdSqlCommandsResponseDto
{
    /// <summary>
    /// <para>如果是 SELECT 命令，返回的是查询结果的 JSON 序列化字符串。如果是其他无返回的命令，如 DELETE 等，result 为空。</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\"}]</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = string.Empty;
}
