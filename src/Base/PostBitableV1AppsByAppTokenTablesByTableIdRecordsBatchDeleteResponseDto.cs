namespace FeishuNetSdk.Base;
/// <summary>
/// 删除多条记录 响应体
/// <para>该接口用于删除数据表中现有的多条记录，单次调用中最多删除 500 条记录。</para>
/// <para>接口ID：6952707657162620930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto
{
    /// <summary>
    /// <para>记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("records")]
    public DeleteRecord[]? Records { get; set; }

    /// <summary>
    /// <para>记录</para>
    /// </summary>
    public record DeleteRecord
    {
        /// <summary>
        /// <para>是否成功删除</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>删除的记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：recpCsf4ME</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }
    }
}
