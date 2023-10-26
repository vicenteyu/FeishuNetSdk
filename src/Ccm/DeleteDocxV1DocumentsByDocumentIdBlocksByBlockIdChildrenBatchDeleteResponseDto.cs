using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除块 响应体
/// <para>指定需要操作的块，删除其指定范围的子块。如果操作成功，接口将返回应用删除操作后的文档版本号。</para>
/// <para>接口ID：7068199542315335708</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fbatch_delete</para>
/// </summary>
public record DeleteDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBatchDeleteResponseDto
{
    /// <summary>
    /// <para>当前删除操作成功后文档的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("document_revision_id")]
    public int? DocumentRevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：是</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// </summary>
    [JsonProperty("client_token")]
    public string ClientToken { get; set; } = string.Empty;
}
