// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-20
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 查询记录 响应体
/// <para>该接口用于查询数据表中的现有记录，单次最多查询 500 行记录，支持分页获取。</para>
/// <para>## 注意事项</para>
/// <para>若多维表格开启了高级权限，你需确保调用身份拥有多维表格的可管理权限，否则可能出现调用成功但返回数据为空的情况。了解具体步骤，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7312729248342360068</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-table-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fsearch</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchResponseDto
{
    /// <summary>
    /// <para>数组类型。record 结果。了解 record 数据结构，参考[数据结构](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTableRecord[]? Items { get; set; }

    /// <summary>
    /// <para>数组类型。record 结果。了解 record 数据结构，参考[数据结构](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)。</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>记录字段</para>
        /// <para>必填：是</para>
        /// <para>示例值：/</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; } = new();

        /// <summary>
        /// <para>记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：recgcfdzKq</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public Person? CreatedBy { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// </summary>
        public record Person
        {
            /// <summary>
            /// <para>人员 ID。与查询参数 user_id_type 指定的类型一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_9a971ded01b4ca66f4798549878abcef</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>中文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：黄小豆</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>英文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Xiaodou Huang</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>邮箱</para>
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
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675244156000</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>修改人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>最近更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1677556020000</para>
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>记录分享链接(批量获取记录接口将返回该字段)</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("shared_url")]
        public string? SharedUrl { get; set; }

        /// <summary>
        /// <para>记录链接(检索记录接口将返回该字段)</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("record_url")]
        public string? RecordUrl { get; set; }
    }

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
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>记录总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
