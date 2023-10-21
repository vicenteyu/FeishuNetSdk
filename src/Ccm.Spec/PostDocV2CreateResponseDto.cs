using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建旧版文档 响应体
/// <para>在使用此接口前，请仔细阅读[文档概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/docs-doc-overview)和[准备接入文档 API](https://open.feishu.cn/document/ukTMukTMukTM/ugzNzUjL4czM14CO3MTN/guide/getting-start)了解文档调用的规则和约束，确保你的文档数据不会丢失或出错。</para>
/// <para>文档数据结构定义可参考：[文档数据结构概述](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)</para>
/// <para>接口ID：6908984614439829506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/apiRef/create-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM2YjL4AjN24COwYjN</para>
/// </summary>
public record PostDocV2CreateResponseDto
{
    /// <summary>
    /// <para>新建文档的token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("objToken")]
    public string? ObjToken { get; set; }

    /// <summary>
    /// <para>新建文档的访问链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }
}
