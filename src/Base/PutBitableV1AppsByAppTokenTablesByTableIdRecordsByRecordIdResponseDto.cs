using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新记录 响应体
/// <para>该接口用于更新数据表中的一条记录</para>
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
    [JsonProperty("record")]
    public AppTableRecord? Record { get; set; }

    /// <summary>
    /// <para>记录更新后的内容</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>一条记录的唯一标识 id [record_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#15d8db94)</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonProperty("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>该记录的创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("created_by")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户的中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：黄小豆</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户的英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XiaodouHuang</para>
            /// </summary>
            [JsonProperty("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>用户的邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：email@example.com</para>
            /// </summary>
            [JsonProperty("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.com/avatar</para>
            /// </summary>
            [JsonProperty("avatar_url")]
            public string? AvatarUrl { get; set; }
        }

        /// <summary>
        /// <para>该记录的创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonProperty("created_time")]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>该记录最新一次更新的修改人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("last_modified_by")]
        public Person? LastModifiedBy { get; set; }

        /// <summary>
        /// <para>该记录最近一次的更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonProperty("last_modified_time")]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>数据表的字段，即数据表的列</para>
        /// <para>当前接口支持的字段类型请参考[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#31f78a3c)</para>
        /// <para>不同类型字段的数据结构请参考[数据结构概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonProperty("fields")]
        public object Fields { get; set; } = new();
    }
}
