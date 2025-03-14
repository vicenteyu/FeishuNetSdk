// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 批量获取记录 响应体
/// <para>通过多个记录 ID 查询记录信息。该接口最多支持查询 100 条记录。</para>
/// <para>## 注意事项</para>
/// <para>若多维表格开启了高级权限，你需确保调用身份拥有多维表格的可管理权限，否则可能出现调用成功但返回数据为空的情况。了解具体步骤，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7386702252390268956</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_get</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetResponseDto
{
    /// <summary>
    /// <para>记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("records")]
    public AppTableRecord[]? Records { get; set; }

    /// <summary>
    /// <para>记录列表</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>记录字段</para>
        /// <para>必填：是</para>
        /// <para>示例值：-</para>
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
        /// <para>创建人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public Person? CreatedBy { get; set; }

        /// <summary>
        /// <para>创建人信息</para>
        /// </summary>
        public record Person
        {
            /// <summary>
            /// <para>创建人 ID。ID 类型与请求体中的 `user_id_type` 指定的类型一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_9a971ded01b4ca66f4798549878abcef</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>创建人中文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张敏</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>创建人英文姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Min Zhang</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>创建人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：email@example.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>创建人头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.com/avatar</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }
        }

        /// <summary>
        /// <para>创建时间。毫秒级时间戳。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675244156000</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>修改人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>最近更新时间。毫秒级时间戳。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1677556020000</para>
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>记录分享链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("shared_url")]
        public string? SharedUrl { get; set; }

        /// <summary>
        /// <para>记录链接（检索记录接口将返回该字段，本接口不返回）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("record_url")]
        public string? RecordUrl { get; set; }
    }

    /// <summary>
    /// <para>禁止访问的记录列表（针对开启了高级权限的多维表格）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("forbidden_record_ids")]
    public string[]? ForbiddenRecordIds { get; set; }

    /// <summary>
    /// <para>不存在的记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("absent_record_ids")]
    public string[]? AbsentRecordIds { get; set; }
}
