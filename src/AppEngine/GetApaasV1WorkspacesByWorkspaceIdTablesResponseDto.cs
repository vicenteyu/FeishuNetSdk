// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-31
//
// Last Modified By : yxr
// Last Modified On : 2025-12-31
// ************************************************************************
// <copyright file="GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取工作空间下的数据表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取工作空间下的数据表列表 响应体
/// <para>获取工作空间下的数据表列表</para>
/// <para>接口ID：7587254819414002901</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2flist</para>
/// </summary>
public record GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto : IPageableResponse<GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto.WorkspaceDataTable>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>数据表列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkspaceDataTable[] Items { get; set; } = [];

    /// <summary>
    /// <para>数据表列表</para>
    /// </summary>
    public record WorkspaceDataTable
    {
        /// <summary>
        /// <para>数据表名，如 student</para>
        /// <para>必填：是</para>
        /// <para>示例值：student</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据表描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：studect数据表</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据表列</para>
        /// <para>必填：是</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("columns")]
        public WorkspaceDataTableColumnInfo[] Columns { get; set; } = [];

        /// <summary>
        /// <para>数据表列</para>
        /// </summary>
        public record WorkspaceDataTableColumnInfo
        {
            /// <summary>
            /// <para>列名</para>
            /// <para>必填：是</para>
            /// <para>示例值：column_name</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>列描述</para>
            /// <para>必填：是</para>
            /// <para>示例值：column_name的描述</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据库数据类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：varchar</para>
            /// </summary>
            [JsonPropertyName("data_type")]
            public string DataType { get; set; } = string.Empty;

            /// <summary>
            /// <para>是否是主键</para>
            /// <para>必填：是</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_primary_key")]
            public bool IsPrimaryKey { get; set; }

            /// <summary>
            /// <para>是否唯一</para>
            /// <para>必填：是</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_unique")]
            public bool IsUnique { get; set; }

            /// <summary>
            /// <para>是否是自增</para>
            /// <para>必填：是</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_auto_increment")]
            public bool IsAutoIncrement { get; set; }

            /// <summary>
            /// <para>是否是数组类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_array")]
            public bool IsArray { get; set; }

            /// <summary>
            /// <para>是否允许为空</para>
            /// <para>必填：是</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_allow_null")]
            public bool IsAllowNull { get; set; }

            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;
        }
    }
}
