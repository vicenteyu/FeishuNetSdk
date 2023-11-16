namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除块 请求体
/// <para>指定需要操作的块，删除其指定范围的子块。如果操作成功，接口将返回应用删除操作后的文档版本号。</para>
/// <para>接口ID：7068199542315335708</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fbatch_delete</para>
/// </summary>
public record DeleteDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBatchDeleteBodyDto
{
    /// <summary>
    /// <para>删除的起始索引（操作区间左闭右开）</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("start_index")]
    public int StartIndex { get; set; }

    /// <summary>
    /// <para>删除的末尾索引（操作区间左闭右开）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("end_index")]
    public int EndIndex { get; set; }
}
