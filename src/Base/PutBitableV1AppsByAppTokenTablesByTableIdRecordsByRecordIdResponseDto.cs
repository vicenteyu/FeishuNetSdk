// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-15
// ************************************************************************
// <copyright file="PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新记录 响应体
/// <para>更新多维表格数据表中的一条记录。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>## 注意事项</para>
/// <para>更新记录为增量更新，仅更新传入的字段。如果想对记录中的某个字段值置空，可将字段设为 null，例如：</para>
/// <para>```json</para>
/// <para>{</para>
/// <para>"fields": {</para>
/// <para>"文本字段": null</para>
/// <para>}</para>
/// <para>}</para>
/// <para>```</para>
/// <para>接口ID：6952707657162637314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fupdate</para>
/// </summary>
public record PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto
{
    /// <summary>
    /// <para>记录更新后的内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("record")]
    public AppTableRecord? Record { get; set; }

    /// <summary>
    /// <para>记录更新后的内容</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>成功更新的记录的数据</para>
        /// <para>必填：是</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; } = new();

        /// <summary>
        /// <para>更新记录的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>该记录的创建人。本接口不返回该参数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public Person? CreatedBy { get; set; }

        /// <summary>
        /// <para>该记录的创建人。本接口不返回该参数</para>
        /// </summary>
        public record Person
        {
            /// <summary>
            /// <para>用户 ID，ID 类型与 `user_id_type` 所指定的类型一致</para>
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
        /// <para>该记录的创建时间。本接口不返回该参数</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>该记录最新一次更新的修改人。本接口不返回该参数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>该记录最近一次的更新时间。本接口不返回该参数</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>记录分享链接。本接口不返回该参数，批量获取记录接口将返回该参数</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("shared_url")]
        public string? SharedUrl { get; set; }

        /// <summary>
        /// <para>记录链接，本接口不返回该参数，查询记录接口将返回该参数</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("record_url")]
        public string? RecordUrl { get; set; }
    }
}
