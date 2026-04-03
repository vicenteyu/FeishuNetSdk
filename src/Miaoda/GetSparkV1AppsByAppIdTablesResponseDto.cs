// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取数据表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取数据表列表 响应体
/// <para>获取应用下的数据表列表，包含数据表名称、描述，以及数据表列信息等字段。</para>
/// <para>接口ID：7620858064161934543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/get_table_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fget_table_list</para>
/// </summary>
public record GetSparkV1AppsByAppIdTablesResponseDto : IPageableResponse<GetSparkV1AppsByAppIdTablesResponseDto.AppTable>
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
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据表列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTable[] Items { get; set; } = [];

    /// <summary>
    /// <para>数据表列表</para>
    /// </summary>
    public record AppTable
    {
        /// <summary>
        /// <para>数据表名，如 student</para>
        /// <para>必填：是</para>
        /// <para>示例值：student</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据表描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：studect数据表</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据表列</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("columns")]
        public AppTableColumn[] Columns { get; set; } = [];

        /// <summary>
        /// <para>数据表列</para>
        /// </summary>
        public record AppTableColumn
        {
            /// <summary>
            /// <para>列名</para>
            /// <para>必填：是</para>
            /// <para>示例值：column_name</para>
            /// <para>最大长度：9999</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>列描述</para>
            /// <para>必填：是</para>
            /// <para>示例值：column_name的描述</para>
            /// <para>最大长度：9999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据库数据类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：varchar</para>
            /// <para>最大长度：9999</para>
            /// <para>最小长度：0</para>
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
            /// <para>示例值：默认值</para>
            /// <para>最大长度：9999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;
        }
    }
}
