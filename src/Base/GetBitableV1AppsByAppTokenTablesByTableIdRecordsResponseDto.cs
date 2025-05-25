// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出记录 响应体
/// <para>该接口用于列出数据表中的现有记录，单次最多列出 500 行记录，支持分页获取。</para>
/// <para>note</para>
/// <para>该接口为历史接口，已不推荐使用。你可使用[查询记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search)替代。</para>
/// <para>接口ID：6952707657162571778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto : IPageableResponse<GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto.AppTableRecord>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>总记录数</para>
    /// <para>必填：否</para>
    /// <para>示例值：\-</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>本次请求返回的全部记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTableRecord[]? Items { get; set; }

    /// <summary>
    /// <para>本次请求返回的全部记录列表</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>一条记录的唯一标识 id [record_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#15d8db94)</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>该记录的创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public Person? CreatedBy { get; set; }

        /// <summary>
        /// <para>该记录的创建人</para>
        /// </summary>
        public record Person
        {
            /// <summary>
            /// <para>用户id，id类型等于user_id_type所指定的类型。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_9a971ded01b4ca66f4798549878abcef</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户的中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：黄小豆</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户的英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Xiaodou Huang</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>用户的邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：email@example.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.com/avatar</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }
        }

        /// <summary>
        /// <para>该记录的创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>该记录最新一次更新的修改人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>该记录最近一次的更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>数据表的字段，即数据表的列</para>
        /// <para>当前接口支持的字段类型请参考[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#31f78a3c)</para>
        /// <para>不同类型字段的数据结构请参考[数据结构概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; } = new();
    }
}
