namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取旧版文档富文本内容 响应体
/// <para>在使用此接口前，请仔细阅读[文档概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/docs-doc-overview)和[准备接入文档 API](https://open.feishu.cn/document/ukTMukTMukTM/ugzNzUjL4czM14CO3MTN/guide/getting-start)了解文档调用的规则和约束，确保你的文档数据不会丢失或出错。</para>
/// <para>文档数据结构定义可参考：[文档数据结构概述](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)</para>
/// <para>接口ID：6908984614439845890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/get-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDM2YjL1AjN24SNwYjN</para>
/// </summary>
public record GetDocV2ByDocTokenContentResponseDto
{
    /// <summary>
    /// <para>详情参考[文档数据结构](https://open.feishu.cn/document/ukTMukTMukTM/ukDM2YjL5AjN24SOwYjN)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>文档当前版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}
